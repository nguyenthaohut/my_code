#include "ConstValue.h"

const char* pSoftVer = "9.0.1"; // 软件版本信息 Boot程序从9.0.0开始
const u8 ToBoot[4] = {0x55,0xaa,0x01,0xbb};
const u8 ToApp[4] = {0x55,0xaa,0x01,0xcc};
u8 UsbError[8] = {0x77,0x77,0x77,0x77,0x66,0x66,0x66,0x66};

