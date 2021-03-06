import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-insert-macota',
  templateUrl: './insert-macota.component.html',
  styleUrls: ['./insert-macota.component.css']
})
export class InsertMacotaComponent implements OnInit {

  constructor(
    private fb: FormBuilder
  ) { }

  contactusForm = this.fb.group({
    persona: this.fb.group({
      nombres: ['', Validators.required],
      precio: ['', Validators.required]
    }),
    email: ['', [Validators.required, Validators.email]],
    mensaje: ['', Validators.required]
  })

  __onSubmit() {
    if(this.contactusForm.valid) {
      console.log(this.contactusForm.value)
    } else {
      alert("Formulario no incompleto..")
    }
  }
  ngOnInit(): void {
  }}  
