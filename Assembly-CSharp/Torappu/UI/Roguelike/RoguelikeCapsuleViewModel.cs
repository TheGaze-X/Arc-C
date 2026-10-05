using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051D7 RID: 20951
	[Token(Token = "0x20051D7")]
	public class RoguelikeCapsuleViewModel : IHotfixable
	{
		// Token: 0x0601EF0E RID: 126734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF0E")]
		[Address(RVA = "0x18AF840", Offset = "0x18AE440", VA = "0x1818AF840")]
		public static RoguelikeCapsuleViewModel Create(string topicId, PlayerRoguelikeV2.CurrentData.Capsule capsule)
		{
			return null;
		}

		// Token: 0x0601EF0F RID: 126735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF0F")]
		[Address(RVA = "0x18AF630", Offset = "0x18AE230", VA = "0x1818AF630")]
		public static RoguelikeCapsuleViewModel Create(string topicId, string capsuleId, bool isActive = true, long ts = -1L)
		{
			return null;
		}

		// Token: 0x0601EF10 RID: 126736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF10")]
		[Address(RVA = "0x18AFA50", Offset = "0x18AE650", VA = "0x1818AFA50")]
		public RoguelikeCapsuleViewModel()
		{
		}

		// Token: 0x04029852 RID: 170066
		[Token(Token = "0x4029852")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04029853 RID: 170067
		[Token(Token = "0x4029853")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x04029854 RID: 170068
		[Token(Token = "0x4029854")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04029855 RID: 170069
		[Token(Token = "0x4029855")]
		[FieldOffset(Offset = "0x28")]
		public string usage;

		// Token: 0x04029856 RID: 170070
		[Token(Token = "0x4029856")]
		[FieldOffset(Offset = "0x30")]
		public bool active;

		// Token: 0x04029857 RID: 170071
		[Token(Token = "0x4029857")]
		[FieldOffset(Offset = "0x38")]
		public long ts;

		// Token: 0x04029858 RID: 170072
		[Token(Token = "0x4029858")]
		[FieldOffset(Offset = "0x40")]
		public Color color;

		// Token: 0x04029859 RID: 170073
		[Token(Token = "0x4029859")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x0402985A RID: 170074
		[Token(Token = "0x402985A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Create;

		// Token: 0x0402985B RID: 170075
		[Token(Token = "0x402985B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
