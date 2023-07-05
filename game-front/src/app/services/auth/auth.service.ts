import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { storageKeyConsts } from 'src/app/shared/const/storage_key_consts';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private login = new BehaviorSubject<boolean>(this.isLoggedIn);

  get isLoggedIn(): boolean {
    return Boolean(JSON.parse(localStorage.getItem(storageKeyConsts.access) ?? 'false'));
  }
  
}
