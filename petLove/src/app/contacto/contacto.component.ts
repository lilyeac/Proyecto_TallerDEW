import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-contacto',
  templateUrl: './contacto.component.html',
  styleUrls: ['./contacto.component.css']
})
export class ContactoComponent implements OnInit {

  constructor(
    private fb: FormBuilder
  ) { }

  contactusForm = this.fb.group({
   
      nombres: ['', Validators.required],
      apellidos: ['', Validators.required],
    
    asunto: ['', [Validators.required, Validators.email]],
    mensaje: ['', Validators.required]
  })

  __onSubmit() {
    if(this.contactusForm.valid) {
      console.log(this.contactusForm.value)
    } else {
      alert("Formulario no valido...")
    }
  }

  ngOnInit(): void {
  }

}
