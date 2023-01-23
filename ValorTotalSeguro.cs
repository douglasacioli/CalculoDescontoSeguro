public class ValorTotalSeguro
{
    Cliente _cliente;
    double _valorSeguroComprado;

    public ValorTotalSeguro(Cliente cliente, double valorSeguroComprado)
    {
        _cliente = cliente;
        _valorSeguroComprado = valorSeguroComprado;
    }

    public double GetValorTotal()
    {
        double valorTotal = 0;
        double desconto = 0;

        if (_cliente._idade >1 && _cliente._idade<=30)
        {
        
            desconto = ((_valorSeguroComprado/100)*0.5);
            valorTotal = _valorSeguroComprado += desconto;
        }
        else if (_cliente._idade >=31 && _cliente._idade <=40)
        {
            desconto = ((_valorSeguroComprado/100)*0);
            valorTotal = _valorSeguroComprado += desconto;
        }
        else if(_cliente._idade >= 41 && _cliente._idade <= 50)
        {
            desconto = ((_valorSeguroComprado/100)*-1);
            valorTotal = _valorSeguroComprado += desconto;
        }
        else if(_cliente._idade >= 51 && _cliente._idade <=65)
        {
            desconto = ((_valorSeguroComprado/100)*-3);
            valorTotal =_valorSeguroComprado += desconto;
        }
        else if(_cliente._idade >= 66 && _cliente._idade <=75)
        {
            desconto = ((_valorSeguroComprado/100)*-5);
            valorTotal = _valorSeguroComprado += desconto;
        }
        else if(_cliente._idade >= 76 && _cliente._idade <= 85)
        {
            desconto = ((_valorSeguroComprado/100)*-7);
            valorTotal = _valorSeguroComprado += desconto;
        }
        else if(_cliente._idade >= 85 && _cliente._idade <= 100)
        {
            desconto = ((_valorSeguroComprado/100)*-10);
            valorTotal = _valorSeguroComprado += desconto;
        }
       
        return valorTotal;
    }
}

