import { Component, OnInit } from '@angular/core';
import { CommonModule, formatDate } from '@angular/common';
import { Item } from "../../../data/interfaces/item";
import { MatCardModule } from "@angular/material/card";
import { HttpClient, HttpClientModule, HttpHeaders } from "@angular/common/http";
import { FormBuilder, Validators } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-form-get',
  standalone: true,
  imports: [CommonModule, MatCardModule, HttpClientModule, ReactiveFormsModule],
  templateUrl: './form-get.component.html',
  styleUrls: ['./form-get.component.css']
})
export class FormGetComponent {
  private readonly apiUrl = "https://localhost:7000/api";
  public Items: Item[] = [];

  formGet = this.formBuilder.group({
    id: ['', Validators.required]
  });

  constructor(private readonly formBuilder: FormBuilder, private readonly httpClient: HttpClient) { }

  getById(): void {
    const id = this.formGet.value.id;

    this.httpClient.get<Item>('${this.apiUrl}/database/model/${id}').subscribe(
      (data: Item) => {
        console.log(data);
        this.Items.push(data);
      }
    );
  }

}
