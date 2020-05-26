using DataModel;
using System.Collections.Generic;

/**
 * Interfata IFilter reprezinta un sablon pentru clasele specifice de filtrare al obiectelor JSON oferite de API.
 * Functionalitatea acestui sablon este de a extrage date dintr-un format specific JSON/XML intr-un model de reprezentare
 * intern.
 * Contine trei metode care definesc ulterioare clase specifice: FilterData, CompleteData si FilterMultipleData.
 * Autor:
 */

namespace FileParser
{
    public interface IFilter
    {
        RecipeData FilterData();
        RecipeData CompleteData(RecipeData dataToBeCompleted);
        List<RecipeData> FilterMultipleData();
    }
}