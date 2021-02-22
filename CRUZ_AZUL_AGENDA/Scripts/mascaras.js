$(function(){
    $("input[data-tipo='cpf']").mask("000.000.000-00");
    $("input[data-tipo='data']").mask("00/00/0000");
    $("input[data-tipo='moeda']").mask("000000000,00", { reverse: true });
    $("input[data-tipo='telefone']").mask("(00) 00000-0000");
    $("input[data-tipo='cep']").mask("00000-000");
});