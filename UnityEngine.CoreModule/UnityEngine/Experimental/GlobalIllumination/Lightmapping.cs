using System;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x020002AB RID: 683
	[Token(Token = "0x20002AB")]
	public static class Lightmapping
	{
		// Token: 0x06000F88 RID: 3976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F88")]
		[Address(RVA = "0x5980B90", Offset = "0x597F790", VA = "0x185980B90")]
		[RequiredByNativeCode]
		public static void SetDelegate(Lightmapping.RequestLightsDelegate del)
		{
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F89")]
		[Address(RVA = "0x5980A00", Offset = "0x597F600", VA = "0x185980A00")]
		[RequiredByNativeCode]
		public static Lightmapping.RequestLightsDelegate GetDelegate()
		{
			return null;
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0x5980B20", Offset = "0x597F720", VA = "0x185980B20")]
		[RequiredByNativeCode]
		public static void ResetDelegate()
		{
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8B")]
		[Address(RVA = "0x5980A50", Offset = "0x597F650", VA = "0x185980A50")]
		[RequiredByNativeCode]
		internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount)
		{
		}

		// Token: 0x04000880 RID: 2176
		[Token(Token = "0x4000880")]
		[FieldOffset(Offset = "0x0")]
		[RequiredByNativeCode]
		private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate;

		// Token: 0x04000881 RID: 2177
		[Token(Token = "0x4000881")]
		[FieldOffset(Offset = "0x8")]
		[RequiredByNativeCode]
		private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate;

		// Token: 0x020002AC RID: 684
		// (Invoke) Token: 0x06000F8E RID: 3982
		[Token(Token = "0x20002AC")]
		public delegate void RequestLightsDelegate(Light[] requests, NativeArray<LightDataGI> lightsOutput);
	}
}
