# SimpleMFAPinCode
Simple MultiForm Authentication for ADFS that tests a hard coded PIN

This is based on: http://blogs.technet.com/b/cloudpfe/archive/2014/02/01/how-to-create-a-custom-authentication-provider-for-active-directory-federation-services-3-0-part-2.aspx

This basically follows the instructions to build the code.
Explanations to install it can be however shortened
- install the signed DLL in the GAC
- use Register-ADFSProvider with a typename which is constructed the following way:
 * first the full namespace name of the class implementing IAuthenticationProvider
 * then the output of the fullname of the assembly
 
 Detailed steps at:
 http://dimitri.janczak.net/2015/08/14/registering-a-custom-adfs-provider-the-easy-way/
 
 
 


