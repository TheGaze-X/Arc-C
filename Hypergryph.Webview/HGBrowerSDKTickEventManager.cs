using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Hypergryph.SDK
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public class HGBrowerSDKTickEventManager
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000004")]
		public static HGBrowerSDKTickEventManager InstanceMangaer
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x4A2DFC0", Offset = "0x4A2CBC0", VA = "0x184A2DFC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x4A2DE00", Offset = "0x4A2CA00", VA = "0x184A2DE00")]
		public void InitTickEvent()
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x4A2DF10", Offset = "0x4A2CB10", VA = "0x184A2DF10")]
		public void UnInitTickEvent()
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HGBrowerSDKTickEventManager()
		{
		}

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x10")]
		private GameObject tickGameObject;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x18")]
		private HGBrowerSDKTickEvent tickEvent;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x0")]
		private static HGBrowerSDKTickEventManager instanceMangaer;
	}
}
