#Prueba de API de NViso

from nviso.threedfi.http import nViso3DFIHttpClient
from nviso.threedfi.http import nViso3DFIException, nViso3DFIRequestError

def main():
    my_app_id       = '3dedb029'
    my_app_key      = '8225b0d6a06112699941df385e28562f'
    client = nViso3DFIHttpClient(my_app_id, my_app_key)
    image_path = 'C:\\Users\\Usuario\\Documents\\AlegreBau.jpg'
    try:
    	with open(image_path, 'rb') as image_data:
    		response = client.process_image_upload(image_data=image_data)
    		print(response.content)
	except nViso3DFIException as e:
    	print 'Error in calling API: %s' % str(e)
	except nViso3DFIRequestError as e:
    	print 'Error returned by API: %s' % str(e)

if __name__ == '__main__':
    main()