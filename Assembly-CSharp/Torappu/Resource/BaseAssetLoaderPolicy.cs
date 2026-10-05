using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Resource
{
	// Token: 0x0200174E RID: 5966
	[Token(Token = "0x200174E")]
	public static class BaseAssetLoaderPolicy
	{
		// Token: 0x0600966A RID: 38506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600966A")]
		public static BaseAssetLoader BindAndGet<T>(T obj) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600966B RID: 38507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600966B")]
		public static void UnBind<T>(T obj) where T : UnityEngine.Object
		{
		}

		// Token: 0x0600966C RID: 38508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600966C")]
		[Address(RVA = "0x311F3A0", Offset = "0x311DFA0", VA = "0x18311F3A0")]
		private static BaseAssetLoader _GetInstance()
		{
			return null;
		}

		// Token: 0x04008CAA RID: 36010
		[Token(Token = "0x4008CAA")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, BaseAssetLoaderPolicy.BindInfoStruct> s_bindInfoDict;

		// Token: 0x04008CAB RID: 36011
		[Token(Token = "0x4008CAB")]
		[FieldOffset(Offset = "0x8")]
		private static BaseAssetLoaderPolicy.BindInfoStruct s_curBindInfo;

		// Token: 0x0200174F RID: 5967
		[Token(Token = "0x200174F")]
		private struct BindInfoStruct
		{
			// Token: 0x0600966E RID: 38510 RVA: 0x0003A980 File Offset: 0x00038B80
			[Token(Token = "0x600966E")]
			[Address(RVA = "0xF58FC0", Offset = "0xF57BC0", VA = "0x180F58FC0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0600966F RID: 38511 RVA: 0x0003A998 File Offset: 0x00038B98
			[Token(Token = "0x600966F")]
			[Address(RVA = "0x311F790", Offset = "0x311E390", VA = "0x18311F790")]
			public bool IsSame(int instId, Type type)
			{
				return default(bool);
			}

			// Token: 0x04008CAC RID: 36012
			[Token(Token = "0x4008CAC")]
			[FieldOffset(Offset = "0x0")]
			public static BaseAssetLoaderPolicy.BindInfoStruct EMPTY;

			// Token: 0x04008CAD RID: 36013
			[Token(Token = "0x4008CAD")]
			[FieldOffset(Offset = "0x0")]
			public Type type;

			// Token: 0x04008CAE RID: 36014
			[Token(Token = "0x4008CAE")]
			[FieldOffset(Offset = "0x8")]
			public int instId;
		}
	}
}
