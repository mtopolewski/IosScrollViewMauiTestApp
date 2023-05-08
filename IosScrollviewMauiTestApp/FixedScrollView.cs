using Microsoft.Maui.Handlers;
#if IOS
using UIKit;
#endif

namespace IosScrollviewMauiTestApp;

public class FixedScrollview : ScrollView
{
  public FixedScrollview()
  {
#if IOS
      ScrollViewHandler.Mapper.AppendToMapping(nameof(IScrollView.ContentSize), OnScrollViewContentSizePropertyChanged);
#endif
  }

#if IOS
  private void OnScrollViewContentSizePropertyChanged(IScrollViewHandler _, IScrollView __)
  {
      if (Handler?.PlatformView is not UIView platformUiView)
          return;
      
      if (platformUiView.Subviews.FirstOrDefault() is not { } contentView)
          return;
      
      contentView.SizeToFit();
  }
#endif
}

