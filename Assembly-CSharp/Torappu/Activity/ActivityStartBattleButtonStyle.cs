using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D67 RID: 28007
	[Token(Token = "0x2006D67")]
	public class ActivityStartBattleButtonStyle : ActivityAssetHolder
	{
		// Token: 0x06027E9A RID: 163482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E9A")]
		[Address(RVA = "0x233E890", Offset = "0x233D490", VA = "0x18233E890", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x06027E9B RID: 163483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E9B")]
		[Address(RVA = "0x233EAE0", Offset = "0x233D6E0", VA = "0x18233EAE0")]
		public ActivityStartBattleButtonStyle.Style TryFindStyle(string styleId)
		{
			return null;
		}

		// Token: 0x06027E9C RID: 163484 RVA: 0x000CFFA8 File Offset: 0x000CE1A8
		[Token(Token = "0x6027E9C")]
		[Address(RVA = "0x233EA00", Offset = "0x233D600", VA = "0x18233EA00", Slot = "7")]
		protected override bool LockAspect(string curAspect, Action<string> setAspect)
		{
			return default(bool);
		}

		// Token: 0x06027E9D RID: 163485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E9D")]
		[Address(RVA = "0x233EBE0", Offset = "0x233D7E0", VA = "0x18233EBE0")]
		public ActivityStartBattleButtonStyle()
		{
		}

		// Token: 0x06027E9E RID: 163486 RVA: 0x000CFFC0 File Offset: 0x000CE1C0
		[Token(Token = "0x6027E9E")]
		[Address(RVA = "0x1140F60", Offset = "0x113FB60", VA = "0x181140F60")]
		private bool <>xLuaBaseProxy_LockAspect(string P0, Action<string> P1)
		{
			return default(bool);
		}

		// Token: 0x04038927 RID: 231719
		[Token(Token = "0x4038927")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActivityStartBattleButtonStyle.Style[] _styles;

		// Token: 0x04038928 RID: 231720
		[Token(Token = "0x4038928")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x04038929 RID: 231721
		[Token(Token = "0x4038929")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryFindStyle;

		// Token: 0x0403892A RID: 231722
		[Token(Token = "0x403892A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LockAspect;

		// Token: 0x0403892B RID: 231723
		[Token(Token = "0x403892B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006D68 RID: 28008
		[Token(Token = "0x2006D68")]
		[Serializable]
		public class Style
		{
			// Token: 0x06027E9F RID: 163487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027E9F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Style()
			{
			}

			// Token: 0x0403892C RID: 231724
			[Token(Token = "0x403892C")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0403892D RID: 231725
			[Token(Token = "0x403892D")]
			[FieldOffset(Offset = "0x18")]
			public Sprite costIcon;

			// Token: 0x0403892E RID: 231726
			[Token(Token = "0x403892E")]
			[FieldOffset(Offset = "0x20")]
			public Sprite buttonImg;

			// Token: 0x0403892F RID: 231727
			[Token(Token = "0x403892F")]
			[FieldOffset(Offset = "0x28")]
			public Sprite costBkg;
		}
	}
}
