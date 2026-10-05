using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A76 RID: 6774
	[Token(Token = "0x2001A76")]
	public class VSandBoxFurnitureEntity : VFurnitureEntity
	{
		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x0600AAC2 RID: 43714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001426")]
		protected override string interactAnimation
		{
			[Token(Token = "0x600AAC2")]
			[Address(RVA = "0x3266530", Offset = "0x3265130", VA = "0x183266530", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AAC3 RID: 43715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAC3")]
		[Address(RVA = "0x32661A0", Offset = "0x3264DA0", VA = "0x1832661A0", Slot = "13")]
		public override void OnInit()
		{
		}

		// Token: 0x0600AAC4 RID: 43716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAC4")]
		[Address(RVA = "0x32660C0", Offset = "0x3264CC0", VA = "0x1832660C0", Slot = "15")]
		public override void OnExit()
		{
		}

		// Token: 0x0600AAC5 RID: 43717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAC5")]
		[Address(RVA = "0x32663B0", Offset = "0x3264FB0", VA = "0x1832663B0")]
		public VSandBoxFurnitureEntity()
		{
		}

		// Token: 0x0600AAC6 RID: 43718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AAC6")]
		[Address(RVA = "0x3261A90", Offset = "0x3260690", VA = "0x183261A90")]
		private string <>xLuaBaseProxy_get_interactAnimation()
		{
			return null;
		}

		// Token: 0x0600AAC7 RID: 43719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAC7")]
		[Address(RVA = "0x32663A0", Offset = "0x3264FA0", VA = "0x1832663A0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600AAC8 RID: 43720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAC8")]
		[Address(RVA = "0x3266390", Offset = "0x3264F90", VA = "0x183266390")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0400A320 RID: 41760
		[Token(Token = "0x400A320")]
		public const string ON_NONE_SEASON = "normalSeason";

		// Token: 0x0400A321 RID: 41761
		[Token(Token = "0x400A321")]
		public const string ON_DRY_SEASON = "drySeason";

		// Token: 0x0400A322 RID: 41762
		[Token(Token = "0x400A322")]
		public const string ON_RAINY_SEASON = "rainySeason";

		// Token: 0x0400A323 RID: 41763
		[Token(Token = "0x400A323")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private string _topicId;

		// Token: 0x0400A324 RID: 41764
		[Token(Token = "0x400A324")]
		[FieldOffset(Offset = "0xF0")]
		private string m_triggerName;

		// Token: 0x0400A325 RID: 41765
		[Token(Token = "0x400A325")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_interactAnimation;

		// Token: 0x0400A326 RID: 41766
		[Token(Token = "0x400A326")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A327 RID: 41767
		[Token(Token = "0x400A327")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400A328 RID: 41768
		[Token(Token = "0x400A328")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
