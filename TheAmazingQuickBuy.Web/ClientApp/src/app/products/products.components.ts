import { Component } from "@angular/core"
@Component({
  selector: "produto",
  template : "<html><body>{{obterNome()}}</body></html> "

})
export class ProductComponent {
  public nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return this.nome;
  }

}
