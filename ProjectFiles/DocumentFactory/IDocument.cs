namespace DocumentFactory
{
    /**
	 * Class Name: IDocument
	 * Purpose:	To create a document template, which will be implemented to create HTML and Markdown documents
	 * Coder: Gui Miranda		
	 * Date: 05/22/2023		
     */
    public interface IDocument
    {
        /*Method Name: AddElement
         *Purpose: Adds an element to the respective document list (HTML or Markdown)
         *Accepts: IElement (an interface for a generic element)
         *Returns: Nothing
         */
        void AddElement(IElement e);

        /*Method Name: RunDocument
         *Purpose: Runs the respective document (HTML or Markdown)
         *Accepts: Nothing
         *Returns: True or False, depending if the action was successful or not
         */
        bool RunDocument();
    }
}