import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})


export class EventosComponent implements OnInit {

  public eventos: any = [];
  public filtedEvents: any = [];
  private _filterList: string = '';

  public get filterList() : string {
    return this._filterList;
  }

  public set filterList(value: string) {
    this._filterList = value;
    this.filtedEvents = this.filterList ? this.filterEvents(this.filterList) : this.eventos;
  }

  filterEvents(filterBy: string): any {
    filterBy = filterBy.toLocaleLowerCase();
    return this.eventos.filter(
      (evento: any) => evento.name.toLocaleLowerCase().indexOf(filterBy) !== -1 ||
      evento.palestrante.toLocaleLowerCase().indexOf(filterBy) !== -1
    )
  }

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): void{
    this.http.get("http://localhost:5270/api/Evento").subscribe(
      response => {
        this.eventos = response;
        this.filtedEvents = this.eventos;

      },
      error => console.log(error)
    )
  }
}
