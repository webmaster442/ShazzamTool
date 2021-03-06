// Sample Syntax for Shazzam XML comments.
// Use the triple slash to (/// ) indicate instructions are for Shazzam and not the HLSL compiler. 

//-------------------------------------------------------------
// Specify a default Class name for generated file.
/// <class>DemoEffect</class>
//-------------------------------------------------------------
// Specify the default >NET namespace.

//-------------------------------------------------------------
// Provide a description for this Shader.
// Shazzam will generate comments from this description.
/// <description>An effect that demonstrates the Shazzam features.</description>

//-----------------------------------------------------------------------------------------
// Define Shader registers.
//-----------------------------------------------------------------------------------------

/// <summary>The second input texture.</summary>
/// <defaultValue>c:\examplefolder\examplefile.jpg</defaultValue> 
sampler2D Texture1 : register(s1);

//--------------------------------------------------------------------------------------
// float
//--------------------------------------------------------------------------------------

// A simple float value.
// Shazzam shows a single editor, with min, max and slider.
float SampleFloat : register(c0);

// A simple float, this time using the Shazzam XML comment.
/// <summary>Summarize the purpose of this variable.</summary> // Causes a tooltip to show in Shazzam.
/// <minValue>-20</minValue>  // provide initial value for the minimum edit textbox.
/// <maxValue>300</maxValue>  // provide initial value for the maximum edit textbox.
/// <defaultValue>120</defaultValue> // provide default value for slider.
float  SampleFloatWithXML : register(C1);

//--------------------------------------------------------------------------------------
// float2
//--------------------------------------------------------------------------------------

// float2 maps to Point, Size or Vector.
// default is Point, change the generated type with <Type> 

/// <summary>Demonstrates the Point syntax.</summary>
/// <minValue>0,5</minValue>
/// <maxValue>20,40</maxValue>
/// <defaultValue>10,10</defaultValue>
/// <type>Point</type>
float2 SamplePoint: register(C2);

/// <summary>Demonstrates the Vector syntax.</summary>
/// <minValue>0,5</minValue>
/// <maxValue>20,40</maxValue>
/// <defaultValue>10,10</defaultValue>
/// <type>Vector</type>
float2 SampleVector : register(C6);

//--------------------------------------------------------------------------------------
// float3
//--------------------------------------------------------------------------------------

// float3 maps to Point3D.
// Not available in Silverlight.

/// <summary>Demonstrates the Point3D syntax.</summary>
/// <minValue>30,10,30</minValue>
/// <maxValue>40,40,40</max Value>
/// <defaultValue>10,10,10</defaultValue>

float3 SamplePoint3D : register(C3);

//--------------------------------------------------------------------------------------
// float4
//--------------------------------------------------------------------------------------

// float4 map to Color or Point4D

/// <summary>Demonstrates the Color syntax.</summary>
/// <defaultValue>Red</defaultValue>
/// <type>Color</type>
float4 SampleColor: register(C4);

/// <summary>Demonstrates the Point4D syntax.</summary>
/// <minValue>50,50,50,50</minValue>
/// <maxValue>80,80,80,80</maxValue>
/// <defaultValue>60,70,60,70</defaultValue>
/// <type>Point4D</type>
float4 SamplePoint4D : register(C5);

//--------------------------------------------------------------------------------------
// Sampler Inputs (Brushes, including ImplicitInput)
//--------------------------------------------------------------------------------------

sampler2D inputSource : register(S0);

//--------------------------------------------------------------------------------------
// Pixel Shader
//--------------------------------------------------------------------------------------

float4 main(float2 uv : TEXCOORD) : COLOR
{
		float4 color;
	  return float4(0,2,3,4);;
}
