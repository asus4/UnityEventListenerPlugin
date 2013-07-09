//
//  UnityEventPlugin.h
//  
//  Created by asus4 on 2013/07/08.
//
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

extern "C" {
    void dispatchNativeUnityEvent(char * msg) {
        [[NSNotificationCenter defaultCenter] postNotificationName:@"UnityEvent" object:nil userInfo:@{@"name":[NSString stringWithUTF8String:msg]}];
    }
}
