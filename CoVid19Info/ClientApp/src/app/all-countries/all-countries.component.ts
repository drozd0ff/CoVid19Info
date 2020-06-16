import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-all-countries',
  templateUrl: './all-countries.component.html',
  styleUrls: ['./all-countries.component.css']
})
export class AllCountriesComponent {
  public countries: AllCountriesModel[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<AllCountriesModel[]>(baseUrl + 'api/countrymodels').subscribe(result => {
        this.countries = result;
      },
      error => console.error(error));
  }
}

interface AllCountriesModel {
  updated: number;
  country: string;
  cases: number;
  todayCases:	number;
  deaths: number;
  todayDeaths: number;
  recovered: number;
  todayRecovered: number;
  active: number;
  critical: number;
  casesPerOneMillion: number;
  deathsPerOneMillion: number;
  tests: number;
  testsPerOneMillion: number;
  population: number;
  continent: string;
  oneCasePerPeople: number;
  oneDeathPerPeople: number;
  oneTestPerPeople: number;
  activePerOneMillion: number;
  recoveredPerOneMillion: number;
  criticalPerOneMillion: number;
}
