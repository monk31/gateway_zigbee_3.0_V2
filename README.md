# gateway_zigbee_3.0_V2
gateway zigbee raspberry JN5189


this repository contains a migration to gateway zigbee with new micontroller JN5189
it use a usb key 0M15080 from NXP semiconductors

![usb](https://github.com/monk31/gateway_zigbee_3.0_V2/assets/13630510/c575a6ea-4cb4-4e75-b4a4-fe1948d3933c)


object xiaomi smart plug and temperature are validated
unfortunately lamp hue cause a problem with Factory reset


To check appairing from your device, you can use the tools ZWGUI
the steps to check your configuration is :
1. configure Settings
2. Open Port
3. Start NWK
4. Permit Join FFFC, FE (orange led must blink)
5. appairing the temperature sensor (push the button during 5 s, light blue must blink)
6. Observe frame temperature and humidity in sheet "Temperature"


![temperature](https://github.com/monk31/gateway_zigbee_3.0_V2/assets/13630510/ba42cc73-4537-46f8-b381-f608dbb3a6d1)



For request with MQTT protocol, you can use a application
compatible with websocket
this application has been tested withIOT/ON off

https://www.iot-onoff.com/





