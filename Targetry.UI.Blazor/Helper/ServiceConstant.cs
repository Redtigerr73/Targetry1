using Microsoft.AspNetCore.Rewrite;
using System.ComponentModel;

namespace Targetry.UI.BlazorWeb.Helper
{
    public static class ServiceConstant
    {
        public const string URLRegex = @"\b(?:https?://|www\.)\S+\b";
    } 
    public static class IconConstant
    {
        public const string SortingIcon = "<svg width=\"24\" height=\"24\" viewBox=\"0 0 20 20\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">" +
            "<path d=\"M8.70879 5.59998L5.60876 2.5L2.50879 5.59998\" stroke=\"#BAB8CF\" stroke-width=\"1.5\" stroke-linecap=\"round\" stroke-linejoin=\"round\" />" +
            "<path d=\"M5.6084 17.5V2.5\" stroke=\"#BAB8CF\" stroke-width=\"1.5\" stroke-linecap=\"round\" stroke-linejoin=\"round\" />" +
            "<path d=\"M11.292 14.4L14.392 17.5L17.492 14.4\" stroke=\"#E6E5ED\" stroke-width=\"1.5\" stroke-linecap=\"round\" stroke-linejoin=\"round\" />" +
            "<path d=\"M14.3926 2.5V17.5\" stroke=\"#E6E5ED\" stroke-width=\"1.5\" stroke-linecap=\"round\" stroke-linejoin=\"round\" />" +
            "</svg>";

        public const string WebsiteIcon = "<svg width=\"22\" height=\"22\" viewBox=\"0 0 17 18\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">" +
            "<path d=\"M14.875 9C14.875 12.5208 12.0208 15.375 8.5 15.375M14.875 9C14.875 5.47918 12.0208 2.625 8.5 2.625M14.875 9H2.125M8.5 15.375C4.97918 15.375 2.125 12.5208 2.125 9M8.5 15.375C9.6736 15.375 10.625 12.5208 10.625 9C10.625 5.47918 9.6736 2.625 8.5 2.625M8.5 15.375C7.32639 15.375 6.375 12.5208 6.375 9C6.375 5.47918 7.32639 2.625 8.5 2.625M2.125 9C2.125 5.47918 4.97918 2.625 8.5 2.625\" stroke=\"#BAB8CF\" stroke-width=\"1.5\" stroke-linecap=\"round\" stroke-linejoin=\"round\" />" +
            "</svg>";

        public const string MailIcon = "<svg width=\"22\" height=\"22\" viewBox=\"0 0 17 18\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">" +
            "<path d=\"M12.0417 15.0209H4.95841C2.83341 15.0209 1.41675 13.9584 1.41675 11.4792V6.52091C1.41675 4.04175 2.83341 2.97925 4.95841 2.97925H12.0417C14.1667 2.97925 15.5834 4.04175 15.5834 6.52091V11.4792C15.5834 13.9584 14.1667 15.0209 12.0417 15.0209Z\" stroke=\"#BAB8CF\" stroke-width=\"1.5\" stroke-miterlimit=\"10\" stroke-linecap=\"round\" stroke-linejoin=\"round\" />" +
            "<path d=\"M12.0416 6.875L9.8245 8.64583C9.09492 9.22667 7.89783 9.22667 7.16825 8.64583L4.95825 6.875\" stroke=\"#BAB8CF\" stroke-width=\"1.5\" stroke-miterlimit=\"10\" stroke-linecap=\"round\" stroke-linejoin=\"round\" />" +
            "</svg>";

        public const string FaxIcon = "<svg width=\"22\" height=\"22\" viewBox=\"0 0 17 18\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">" +
            "<path d=\"M5.13525 5.45841H11.8644V4.04175C11.8644 2.62508 11.3332 1.91675 9.73942 1.91675H7.26025C5.6665 1.91675 5.13525 2.62508 5.13525 4.04175V5.45841Z\" stroke=\"#BAB8CF\" stroke-width=\"1.5\" stroke-miterlimit=\"10\" stroke-linecap=\"round\" stroke-linejoin=\"round\"/>" +
            "<path d=\"M11.3332 11.125V13.9583C11.3332 15.375 10.6248 16.0833 9.20817 16.0833H7.7915C6.37484 16.0833 5.6665 15.375 5.6665 13.9583V11.125H11.3332Z\" stroke=\"#BAB8CF\" stroke-width=\"1.5\" stroke-miterlimit=\"10\" stroke-linecap=\"round\" stroke-linejoin=\"round\"/>" +
            "<path d=\"M14.875 7.58325V11.1249C14.875 12.5416 14.1667 13.2499 12.75 13.2499H11.3333V11.1249H5.66667V13.2499H4.25C2.83333 13.2499 2.125 12.5416 2.125 11.1249V7.58325C2.125 6.16659 2.83333 5.45825 4.25 5.45825H12.75C14.1667 5.45825 14.875 6.16659 14.875 7.58325Z\" stroke=\"#BAB8CF\" stroke-width=\"1.5\" stroke-miterlimit=\"10\" stroke-linecap=\"round\" stroke-linejoin=\"round\"/>" +
            "<path d=\"M12.0418 11.125H11.1847H4.9585\" stroke=\"#BAB8CF\" stroke-width=\"1.5\" stroke-miterlimit=\"10\" stroke-linecap=\"round\" stroke-linejoin=\"round\"/>\r\n<path d=\"M4.9585 8.29175H7.0835\" stroke=\"#BAB8CF\" stroke-width=\"1.5\" stroke-miterlimit=\"10\" stroke-linecap=\"round\" stroke-linejoin=\"round\"/>" +
            "</svg>"; 
        public const string TrashIcon = "<svg width=\"20\" height=\"20\" viewBox=\"0 0 20 20\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">\r\n<path d=\"M15.8335 5.83333L15.1107 15.9521C15.0484 16.8243 14.3227 17.5 13.4483 17.5H6.55203C5.67763 17.5 4.9519 16.8243 4.8896 15.9521L4.16683 5.83333M8.3335 9.16667V14.1667M11.6668 9.16667V14.1667M12.5002 5.83333V3.33333C12.5002 2.8731 12.1271 2.5 11.6668 2.5H8.3335C7.87326 2.5 7.50016 2.8731 7.50016 3.33333V5.83333M3.3335 5.83333H16.6668\" stroke=\"#FF4E3E\" stroke-width=\"1.5\" stroke-linecap=\"round\" stroke-linejoin=\"round\"/>\r\n</svg>\r\n";
        
        public const string UserIcon = "<svg width=\"22\" height=\"22\" viewBox=\"0 0 17 18\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">" +
            "<path d=\"M8.61331 8.19954C8.54248 8.19246 8.45748 8.19246 8.37956 8.19954C6.69373 8.14288 5.35498 6.76163 5.35498 5.06163C5.35498 3.32621 6.75748 1.91663 8.49998 1.91663C10.2354 1.91663 11.645 3.32621 11.645 5.06163C11.6379 6.76163 10.2991 8.14288 8.61331 8.19954Z\" stroke=\"#BAB8CF\" stroke-width=\"1.5\" stroke-linecap=\"round\" stroke-linejoin=\"round\"/>" +
            "<path d=\"M5.07176 10.8134C3.35759 11.9609 3.35759 13.8309 5.07176 14.9713C7.01967 16.2746 10.2143 16.2746 12.1622 14.9713C13.8763 13.8238 13.8763 11.9538 12.1622 10.8134C10.2213 9.51712 7.02676 9.51712 5.07176 10.8134Z\" stroke=\"#BAB8CF\" stroke-width=\"1.5\" stroke-linecap=\"round\" stroke-linejoin=\"round\"/>" +
            "</svg>";

        public const string CalendarIcon = "<svg width=\"22\" height=\"22\" viewBox=\"0 0 17 18\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">" +
            "<path d=\"M5.66667 5.45833V2.625M11.3333 5.45833V2.625M4.95833 8.29167H12.0417M3.54167 15.375H13.4583C14.2407 15.375 14.875 14.7407 14.875 13.9583V5.45833C14.875 4.67593 14.2407 4.04167 13.4583 4.04167H3.54167C2.75926 4.04167 2.125 4.67593 2.125 5.45833V13.9583C2.125 14.7407 2.75926 15.375 3.54167 15.375Z\" stroke=\"#BAB8CF\" stroke-width=\"1.5\" stroke-linecap=\"round\" stroke-linejoin=\"round\"/>" +
            "</svg>";
        
        public const string AttachmentIcon = "<svg width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\">" +
            "<path d=\"M16.1248 6.50002V17.0417C16.1248 19.0675 14.484 20.7084 12.4582 20.7084C10.4323 20.7084 8.7915 19.0675 8.7915 17.0417V5.58335C8.7915 4.31835 9.81817 3.29169 11.0832 3.29169C12.3482 3.29169 13.3748 4.31835 13.3748 5.58335V15.2084C13.3748 15.7125 12.9623 16.125 12.4582 16.125C11.954 16.125 11.5415 15.7125 11.5415 15.2084V6.50002H10.1665V15.2084C10.1665 16.4734 11.1932 17.5 12.4582 17.5C13.7232 17.5 14.7498 16.4734 14.7498 15.2084V5.58335C14.7498 3.55752 13.109 1.91669 11.0832 1.91669C9.05734 1.91669 7.4165 3.55752 7.4165 5.58335V17.0417C7.4165 19.8284 9.6715 22.0834 12.4582 22.0834C15.2448 22.0834 17.4998 19.8284 17.4998 17.0417V6.50002H16.1248Z\" fill=\"#5D5B70\" />" +
            "</svg>";

        public const string SearchIcon = "<svg width=\"24\" height=\"24\" viewBox=\"0 0 24 24\" fill=\"none\" xmlns=\"http://www.w3.org/2000/svg\"><path d=\"M16 16L21 21\" stroke=\"#67A4FF\" stroke-width=\"2\"/><circle cx=\"9.5\" cy=\"9.5\" r=\"6.5\" stroke=\"#67A4FF\" stroke-width=\"2\"/></svg>";
    }
    public enum FormAction { Edit, Create, View }
}
