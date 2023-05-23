namespace DocumentFactory
{
    /**
	 * Class Name: IDocument
	 * Purpose:			
	 * Coder: Gui Miranda		
	 * Date: 05/22/2023		
     */
    public interface IDocument
    {
        /*Method Name: AddElement
         *Purpose:
         *Accepts: IElement (an interface for a generic element)
         *Returns: Nothing
         */
        void AddElement(IElement e);

        /*Method Name: RunDocument
         *Purpose:
         *Accepts: Nothing
         *Returns: True or False, depending if the action was successful or not
         */
        bool RunDocument();
    }
}