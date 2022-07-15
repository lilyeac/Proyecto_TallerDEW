import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-recupera-contrasenia',
  templateUrl: './recupera-contrasenia.component.html',
  styleUrls: ['./recupera-contrasenia.component.css']
})
export class RecuperaContraseniaComponent implements OnInit {

  constructor(
    private fb: FormBuilder
  ) { }

  contactusForm = this.fb.group({
   
       
    email: ['', [Validators.required, Validators.email]]
    
  })

  __onSubmit() {
    if(this.contactusForm.valid) {
      console.log(this.contactusForm.value)
    } else {
      alert("Correo invalido...")
    }
  }

  ngOnInit(): void {
  }

}