/**
 * Interfata IParse reprezinta un sablon pentru clasele specifice de parsare a query-urilor necesare 
 * clasei ClientAPI
 * Contine o singura metoda de creare a query-ului: CreateQuery
 * Autor: Cotovanu Stefania
 */

namespace ControllerNamespace
{
    interface IParse
    {
        string CreateQuery();
    }
}
