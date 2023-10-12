
# How to add the SVG images in Xamarin.Forms button

Syncfusion Xamarin.Forms SfButton provides a support to get an elegant view in your application by setting background image and also display the button text along with the image. This article mainly explains how to use SVG image in it.



## Available features to achieve it

 

Image and ImageSource properties in Xamarin.Forms SfButton to display the image along with the text.

 

BackgroundImage property to display the background image of Xamarin.Forms SfButton.

 

## Needed package

 

Xamarin.Forms.Svg provides SvgImageSource to add Xamarin.Forms ImageSource.

## How to use it in SfButton
By setting the SvgImageSource to the available image support properties in SfButton, you can achieve this as shown in the following code snippet.

 
**[XAML]**

```
<buttons:SfButton BackgroundColor="##51E2F5" 
                          BorderWidth="2" 
                          BorderColor="Red" 
                          HorizontalOptions="Center"
                          VerticalOptions="Center"
                          WidthRequest="100" >
        <Image>
            <Image.Source>
                    <svg:SvgImageSource Source="Typogy1.svg" Width="40" Height="50" />
            </Image.Source>
        </Image>
        </buttons:SfButton>
        
        <buttons:SfButton  
            ShowIcon="True" 
            HorizontalOptions="Center" 
            VerticalOptions="Center"  
            WidthRequest="150" 
            HeightRequest="50"
            Margin="0,50,0,0"
            Text="Add to card">
            <buttons:SfButton.ImageSource>
                <svg:SvgImageSource Source="commerce-and-shopping.svg" Width="40" Height="50" Color="White"/>
            </buttons:SfButton.ImageSource>
        </buttons:SfButton>
        
        <buttons:SfButton 
            TextColor="White"
            WidthRequest="100"
            HorizontalOptions="Center" 
            VerticalOptions="Center" 
            Margin="0,50,0,0"
            Text="Login">
            <buttons:SfButton.BackgroundImage>
                <svg:SvgImageSource Source="background.svg" Width="40" Height="50" />
            </buttons:SfButton.BackgroundImage>
        </buttons:SfButton>
```

Additional things to do that to make it render.

 In Android: Add Xamarin.Forms.Svg.Droid.SvgImage.Init(this).

**[C#]**

```

public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        TabLayoutResource = Resource.Layout.Tabbar;
        ToolbarResource = Resource.Layout.Toolbar;            base.OnCreate(savedInstanceState);
        global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
        Xamarin.Forms.Svg.Droid.SvgImage.Init(this);
        LoadApplication(new App());
    }
}
```
In iOS: Add Xamarin.Forms.Svg.iOS.SvgImage.Init().

 
**[C#]**

 
```
public override bool FinishedLaunching(UIApplication app, NSDictionary options)
{
    global::Xamarin.Forms.Forms.Init();
 
    Xamarin.Forms.Svg.iOS.SvgImage.Init();
    Syncfusion.XForms.iOS.Border.SfBorderRenderer.Init();
    Syncfusion.XForms.iOS.Buttons.SfButtonRenderer.Init(); 
    LoadApplication(new App()); 
    return base.FinishedLaunching(app, options);
}
```

## How to run this application?

To run this application, you need to first clone the How-to-use-SVG-images-in-Xamarin.Forms-button repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.