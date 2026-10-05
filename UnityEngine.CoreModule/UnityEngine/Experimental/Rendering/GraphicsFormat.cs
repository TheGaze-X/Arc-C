using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020002B9 RID: 697
	[Token(Token = "0x20002B9")]
	public enum GraphicsFormat
	{
		// Token: 0x040008A3 RID: 2211
		[Token(Token = "0x40008A3")]
		None,
		// Token: 0x040008A4 RID: 2212
		[Token(Token = "0x40008A4")]
		R8_SRGB,
		// Token: 0x040008A5 RID: 2213
		[Token(Token = "0x40008A5")]
		R8G8_SRGB,
		// Token: 0x040008A6 RID: 2214
		[Token(Token = "0x40008A6")]
		R8G8B8_SRGB,
		// Token: 0x040008A7 RID: 2215
		[Token(Token = "0x40008A7")]
		R8G8B8A8_SRGB,
		// Token: 0x040008A8 RID: 2216
		[Token(Token = "0x40008A8")]
		R8_UNorm,
		// Token: 0x040008A9 RID: 2217
		[Token(Token = "0x40008A9")]
		R8G8_UNorm,
		// Token: 0x040008AA RID: 2218
		[Token(Token = "0x40008AA")]
		R8G8B8_UNorm,
		// Token: 0x040008AB RID: 2219
		[Token(Token = "0x40008AB")]
		R8G8B8A8_UNorm,
		// Token: 0x040008AC RID: 2220
		[Token(Token = "0x40008AC")]
		R8_SNorm,
		// Token: 0x040008AD RID: 2221
		[Token(Token = "0x40008AD")]
		R8G8_SNorm,
		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x40008AE")]
		R8G8B8_SNorm,
		// Token: 0x040008AF RID: 2223
		[Token(Token = "0x40008AF")]
		R8G8B8A8_SNorm,
		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		R8_UInt,
		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		R8G8_UInt,
		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		R8G8B8_UInt,
		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		R8G8B8A8_UInt,
		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		R8_SInt,
		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		R8G8_SInt,
		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		R8G8B8_SInt,
		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		R8G8B8A8_SInt,
		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		R16_UNorm,
		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		R16G16_UNorm,
		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		R16G16B16_UNorm,
		// Token: 0x040008BB RID: 2235
		[Token(Token = "0x40008BB")]
		R16G16B16A16_UNorm,
		// Token: 0x040008BC RID: 2236
		[Token(Token = "0x40008BC")]
		R16_SNorm,
		// Token: 0x040008BD RID: 2237
		[Token(Token = "0x40008BD")]
		R16G16_SNorm,
		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		R16G16B16_SNorm,
		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x40008BF")]
		R16G16B16A16_SNorm,
		// Token: 0x040008C0 RID: 2240
		[Token(Token = "0x40008C0")]
		R16_UInt,
		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x40008C1")]
		R16G16_UInt,
		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		R16G16B16_UInt,
		// Token: 0x040008C3 RID: 2243
		[Token(Token = "0x40008C3")]
		R16G16B16A16_UInt,
		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x40008C4")]
		R16_SInt,
		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x40008C5")]
		R16G16_SInt,
		// Token: 0x040008C6 RID: 2246
		[Token(Token = "0x40008C6")]
		R16G16B16_SInt,
		// Token: 0x040008C7 RID: 2247
		[Token(Token = "0x40008C7")]
		R16G16B16A16_SInt,
		// Token: 0x040008C8 RID: 2248
		[Token(Token = "0x40008C8")]
		R32_UInt,
		// Token: 0x040008C9 RID: 2249
		[Token(Token = "0x40008C9")]
		R32G32_UInt,
		// Token: 0x040008CA RID: 2250
		[Token(Token = "0x40008CA")]
		R32G32B32_UInt,
		// Token: 0x040008CB RID: 2251
		[Token(Token = "0x40008CB")]
		R32G32B32A32_UInt,
		// Token: 0x040008CC RID: 2252
		[Token(Token = "0x40008CC")]
		R32_SInt,
		// Token: 0x040008CD RID: 2253
		[Token(Token = "0x40008CD")]
		R32G32_SInt,
		// Token: 0x040008CE RID: 2254
		[Token(Token = "0x40008CE")]
		R32G32B32_SInt,
		// Token: 0x040008CF RID: 2255
		[Token(Token = "0x40008CF")]
		R32G32B32A32_SInt,
		// Token: 0x040008D0 RID: 2256
		[Token(Token = "0x40008D0")]
		R16_SFloat,
		// Token: 0x040008D1 RID: 2257
		[Token(Token = "0x40008D1")]
		R16G16_SFloat,
		// Token: 0x040008D2 RID: 2258
		[Token(Token = "0x40008D2")]
		R16G16B16_SFloat,
		// Token: 0x040008D3 RID: 2259
		[Token(Token = "0x40008D3")]
		R16G16B16A16_SFloat,
		// Token: 0x040008D4 RID: 2260
		[Token(Token = "0x40008D4")]
		R32_SFloat,
		// Token: 0x040008D5 RID: 2261
		[Token(Token = "0x40008D5")]
		R32G32_SFloat,
		// Token: 0x040008D6 RID: 2262
		[Token(Token = "0x40008D6")]
		R32G32B32_SFloat,
		// Token: 0x040008D7 RID: 2263
		[Token(Token = "0x40008D7")]
		R32G32B32A32_SFloat,
		// Token: 0x040008D8 RID: 2264
		[Token(Token = "0x40008D8")]
		B8G8R8_SRGB = 56,
		// Token: 0x040008D9 RID: 2265
		[Token(Token = "0x40008D9")]
		B8G8R8A8_SRGB,
		// Token: 0x040008DA RID: 2266
		[Token(Token = "0x40008DA")]
		B8G8R8_UNorm,
		// Token: 0x040008DB RID: 2267
		[Token(Token = "0x40008DB")]
		B8G8R8A8_UNorm,
		// Token: 0x040008DC RID: 2268
		[Token(Token = "0x40008DC")]
		B8G8R8_SNorm,
		// Token: 0x040008DD RID: 2269
		[Token(Token = "0x40008DD")]
		B8G8R8A8_SNorm,
		// Token: 0x040008DE RID: 2270
		[Token(Token = "0x40008DE")]
		B8G8R8_UInt,
		// Token: 0x040008DF RID: 2271
		[Token(Token = "0x40008DF")]
		B8G8R8A8_UInt,
		// Token: 0x040008E0 RID: 2272
		[Token(Token = "0x40008E0")]
		B8G8R8_SInt,
		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x40008E1")]
		B8G8R8A8_SInt,
		// Token: 0x040008E2 RID: 2274
		[Token(Token = "0x40008E2")]
		R4G4B4A4_UNormPack16,
		// Token: 0x040008E3 RID: 2275
		[Token(Token = "0x40008E3")]
		B4G4R4A4_UNormPack16,
		// Token: 0x040008E4 RID: 2276
		[Token(Token = "0x40008E4")]
		R5G6B5_UNormPack16,
		// Token: 0x040008E5 RID: 2277
		[Token(Token = "0x40008E5")]
		B5G6R5_UNormPack16,
		// Token: 0x040008E6 RID: 2278
		[Token(Token = "0x40008E6")]
		R5G5B5A1_UNormPack16,
		// Token: 0x040008E7 RID: 2279
		[Token(Token = "0x40008E7")]
		B5G5R5A1_UNormPack16,
		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x40008E8")]
		A1R5G5B5_UNormPack16,
		// Token: 0x040008E9 RID: 2281
		[Token(Token = "0x40008E9")]
		E5B9G9R9_UFloatPack32,
		// Token: 0x040008EA RID: 2282
		[Token(Token = "0x40008EA")]
		B10G11R11_UFloatPack32,
		// Token: 0x040008EB RID: 2283
		[Token(Token = "0x40008EB")]
		A2B10G10R10_UNormPack32,
		// Token: 0x040008EC RID: 2284
		[Token(Token = "0x40008EC")]
		A2B10G10R10_UIntPack32,
		// Token: 0x040008ED RID: 2285
		[Token(Token = "0x40008ED")]
		A2B10G10R10_SIntPack32,
		// Token: 0x040008EE RID: 2286
		[Token(Token = "0x40008EE")]
		A2R10G10B10_UNormPack32,
		// Token: 0x040008EF RID: 2287
		[Token(Token = "0x40008EF")]
		A2R10G10B10_UIntPack32,
		// Token: 0x040008F0 RID: 2288
		[Token(Token = "0x40008F0")]
		A2R10G10B10_SIntPack32,
		// Token: 0x040008F1 RID: 2289
		[Token(Token = "0x40008F1")]
		A2R10G10B10_XRSRGBPack32,
		// Token: 0x040008F2 RID: 2290
		[Token(Token = "0x40008F2")]
		A2R10G10B10_XRUNormPack32,
		// Token: 0x040008F3 RID: 2291
		[Token(Token = "0x40008F3")]
		R10G10B10_XRSRGBPack32,
		// Token: 0x040008F4 RID: 2292
		[Token(Token = "0x40008F4")]
		R10G10B10_XRUNormPack32,
		// Token: 0x040008F5 RID: 2293
		[Token(Token = "0x40008F5")]
		A10R10G10B10_XRSRGBPack32,
		// Token: 0x040008F6 RID: 2294
		[Token(Token = "0x40008F6")]
		A10R10G10B10_XRUNormPack32,
		// Token: 0x040008F7 RID: 2295
		[Token(Token = "0x40008F7")]
		D16_UNorm = 90,
		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x40008F8")]
		D24_UNorm,
		// Token: 0x040008F9 RID: 2297
		[Token(Token = "0x40008F9")]
		D24_UNorm_S8_UInt,
		// Token: 0x040008FA RID: 2298
		[Token(Token = "0x40008FA")]
		D32_SFloat,
		// Token: 0x040008FB RID: 2299
		[Token(Token = "0x40008FB")]
		D32_SFloat_S8_UInt,
		// Token: 0x040008FC RID: 2300
		[Token(Token = "0x40008FC")]
		S8_UInt,
		// Token: 0x040008FD RID: 2301
		[Token(Token = "0x40008FD")]
		[Obsolete("Enum member GraphicsFormat.RGB_DXT1_SRGB has been deprecated. Use GraphicsFormat.RGBA_DXT1_SRGB instead (UnityUpgradable) -> RGBA_DXT1_SRGB", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		RGB_DXT1_SRGB,
		// Token: 0x040008FE RID: 2302
		[Token(Token = "0x40008FE")]
		RGBA_DXT1_SRGB = 96,
		// Token: 0x040008FF RID: 2303
		[Token(Token = "0x40008FF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Enum member GraphicsFormat.RGB_DXT1_UNorm has been deprecated. Use GraphicsFormat.RGBA_DXT1_UNorm instead (UnityUpgradable) -> RGBA_DXT1_UNorm", true)]
		RGB_DXT1_UNorm,
		// Token: 0x04000900 RID: 2304
		[Token(Token = "0x4000900")]
		RGBA_DXT1_UNorm = 97,
		// Token: 0x04000901 RID: 2305
		[Token(Token = "0x4000901")]
		RGBA_DXT3_SRGB,
		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		RGBA_DXT3_UNorm,
		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000903")]
		RGBA_DXT5_SRGB,
		// Token: 0x04000904 RID: 2308
		[Token(Token = "0x4000904")]
		RGBA_DXT5_UNorm,
		// Token: 0x04000905 RID: 2309
		[Token(Token = "0x4000905")]
		R_BC4_UNorm,
		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		R_BC4_SNorm,
		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		RG_BC5_UNorm,
		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000908")]
		RG_BC5_SNorm,
		// Token: 0x04000909 RID: 2313
		[Token(Token = "0x4000909")]
		RGB_BC6H_UFloat,
		// Token: 0x0400090A RID: 2314
		[Token(Token = "0x400090A")]
		RGB_BC6H_SFloat,
		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400090B")]
		RGBA_BC7_SRGB,
		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400090C")]
		RGBA_BC7_UNorm,
		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400090D")]
		RGB_PVRTC_2Bpp_SRGB,
		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x400090E")]
		RGB_PVRTC_2Bpp_UNorm,
		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x400090F")]
		RGB_PVRTC_4Bpp_SRGB,
		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4000910")]
		RGB_PVRTC_4Bpp_UNorm,
		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000911")]
		RGBA_PVRTC_2Bpp_SRGB,
		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		RGBA_PVRTC_2Bpp_UNorm,
		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		RGBA_PVRTC_4Bpp_SRGB,
		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		RGBA_PVRTC_4Bpp_UNorm,
		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000915")]
		RGB_ETC_UNorm,
		// Token: 0x04000916 RID: 2326
		[Token(Token = "0x4000916")]
		RGB_ETC2_SRGB,
		// Token: 0x04000917 RID: 2327
		[Token(Token = "0x4000917")]
		RGB_ETC2_UNorm,
		// Token: 0x04000918 RID: 2328
		[Token(Token = "0x4000918")]
		RGB_A1_ETC2_SRGB,
		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		RGB_A1_ETC2_UNorm,
		// Token: 0x0400091A RID: 2330
		[Token(Token = "0x400091A")]
		RGBA_ETC2_SRGB,
		// Token: 0x0400091B RID: 2331
		[Token(Token = "0x400091B")]
		RGBA_ETC2_UNorm,
		// Token: 0x0400091C RID: 2332
		[Token(Token = "0x400091C")]
		R_EAC_UNorm,
		// Token: 0x0400091D RID: 2333
		[Token(Token = "0x400091D")]
		R_EAC_SNorm,
		// Token: 0x0400091E RID: 2334
		[Token(Token = "0x400091E")]
		RG_EAC_UNorm,
		// Token: 0x0400091F RID: 2335
		[Token(Token = "0x400091F")]
		RG_EAC_SNorm,
		// Token: 0x04000920 RID: 2336
		[Token(Token = "0x4000920")]
		RGBA_ASTC4X4_SRGB,
		// Token: 0x04000921 RID: 2337
		[Token(Token = "0x4000921")]
		RGBA_ASTC4X4_UNorm,
		// Token: 0x04000922 RID: 2338
		[Token(Token = "0x4000922")]
		RGBA_ASTC5X5_SRGB,
		// Token: 0x04000923 RID: 2339
		[Token(Token = "0x4000923")]
		RGBA_ASTC5X5_UNorm,
		// Token: 0x04000924 RID: 2340
		[Token(Token = "0x4000924")]
		RGBA_ASTC6X6_SRGB,
		// Token: 0x04000925 RID: 2341
		[Token(Token = "0x4000925")]
		RGBA_ASTC6X6_UNorm,
		// Token: 0x04000926 RID: 2342
		[Token(Token = "0x4000926")]
		RGBA_ASTC8X8_SRGB,
		// Token: 0x04000927 RID: 2343
		[Token(Token = "0x4000927")]
		RGBA_ASTC8X8_UNorm,
		// Token: 0x04000928 RID: 2344
		[Token(Token = "0x4000928")]
		RGBA_ASTC10X10_SRGB,
		// Token: 0x04000929 RID: 2345
		[Token(Token = "0x4000929")]
		RGBA_ASTC10X10_UNorm,
		// Token: 0x0400092A RID: 2346
		[Token(Token = "0x400092A")]
		RGBA_ASTC12X12_SRGB,
		// Token: 0x0400092B RID: 2347
		[Token(Token = "0x400092B")]
		RGBA_ASTC12X12_UNorm,
		// Token: 0x0400092C RID: 2348
		[Token(Token = "0x400092C")]
		YUV2,
		// Token: 0x0400092D RID: 2349
		[Token(Token = "0x400092D")]
		[Obsolete("Enum member GraphicsFormat.DepthAuto has been deprecated. Use GraphicsFormat.None as a color format to indicate depth only rendering and DefaultFormat to get the default depth buffer format.", false)]
		DepthAuto,
		// Token: 0x0400092E RID: 2350
		[Token(Token = "0x400092E")]
		[Obsolete("Enum member GraphicsFormat.ShadowAuto has been deprecated. Use GraphicsFormat.None as a color format to indicate depth only rendering and DefaultFormat to get the default shadow buffer format.", false)]
		ShadowAuto,
		// Token: 0x0400092F RID: 2351
		[Token(Token = "0x400092F")]
		[Obsolete("Enum member GraphicsFormat.VideoAuto has been deprecated. Use DefaultFormat instead.", false)]
		VideoAuto,
		// Token: 0x04000930 RID: 2352
		[Token(Token = "0x4000930")]
		RGBA_ASTC4X4_UFloat,
		// Token: 0x04000931 RID: 2353
		[Token(Token = "0x4000931")]
		RGBA_ASTC5X5_UFloat,
		// Token: 0x04000932 RID: 2354
		[Token(Token = "0x4000932")]
		RGBA_ASTC6X6_UFloat,
		// Token: 0x04000933 RID: 2355
		[Token(Token = "0x4000933")]
		RGBA_ASTC8X8_UFloat,
		// Token: 0x04000934 RID: 2356
		[Token(Token = "0x4000934")]
		RGBA_ASTC10X10_UFloat,
		// Token: 0x04000935 RID: 2357
		[Token(Token = "0x4000935")]
		RGBA_ASTC12X12_UFloat
	}
}
