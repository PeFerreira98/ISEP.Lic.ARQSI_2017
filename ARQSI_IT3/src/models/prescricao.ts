import { Aviamento } from "./aviamento";

export class Prescricao {
    _id: string;
    __v: string;
    numero: Number;
    quantidade: Number;
    apresentacaoID: string;
    apresentacao: string;
    aviamentos: Aviamento[];
}