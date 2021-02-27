import { TrainingroompersonComponent } from './trainingroomperson/trainingroomperson.component';
import { StagetimeComponent } from './stagetime/stagetime.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainComponent } from './main/main.component';
import { PersonComponent } from './person/person.component';
import { RestroomComponent } from './restroom/restroom.component';
import { RestroompersonComponent } from './restroomperson/restroomperson.component';
import { TrainingroomComponent } from './trainingroom/trainingroom.component';

const routes: Routes = [
  { path: '', redirectTo: 'main', pathMatch: 'full' },
  { path: 'main', component : MainComponent },
  { path: 'person', component: PersonComponent },
  { path: 'restroom', component: RestroomComponent },
  { path: 'restroomperson', component: RestroompersonComponent },
  { path: 'resttime', component: RestroomComponent },
  { path: 'stagetime', component: StagetimeComponent },
  { path: 'trainingroom', component: TrainingroomComponent },
  { path: 'trainingroomperson', component: TrainingroompersonComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
