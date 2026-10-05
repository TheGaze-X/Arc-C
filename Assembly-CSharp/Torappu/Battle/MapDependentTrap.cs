using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002602 RID: 9730
	[Token(Token = "0x2002602")]
	[SelectionBase]
	public class MapDependentTrap : Trap
	{
		// Token: 0x0600FD69 RID: 64873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD69")]
		[Address(RVA = "0x75A070", Offset = "0x758C70", VA = "0x18075A070", Slot = "183")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600FD6A RID: 64874 RVA: 0x0005FDD8 File Offset: 0x0005DFD8
		[Token(Token = "0x600FD6A")]
		[Address(RVA = "0x75A0F0", Offset = "0x758CF0", VA = "0x18075A0F0")]
		private bool _CheckNeedToLoadSkin()
		{
			return default(bool);
		}

		// Token: 0x0600FD6B RID: 64875 RVA: 0x0005FDF0 File Offset: 0x0005DFF0
		[Token(Token = "0x600FD6B")]
		[Address(RVA = "0x75A180", Offset = "0x758D80", VA = "0x18075A180")]
		private bool _TryLoadSkin()
		{
			return default(bool);
		}

		// Token: 0x0600FD6C RID: 64876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD6C")]
		[Address(RVA = "0x75A4F0", Offset = "0x7590F0", VA = "0x18075A4F0")]
		public MapDependentTrap()
		{
		}

		// Token: 0x0600FD6D RID: 64877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD6D")]
		[Address(RVA = "0x75A0E0", Offset = "0x758CE0", VA = "0x18075A0E0")]
		private void <>xLuaBaseProxy_OnAwake()
		{
		}

		// Token: 0x040119B7 RID: 72119
		[Token(Token = "0x40119B7")]
		private const string SKIN_INSTANCE_NAME = "Graphic";

		// Token: 0x040119B8 RID: 72120
		[Token(Token = "0x40119B8")]
		[FieldOffset(Offset = "0x578")]
		[SerializeField]
		[Group("Skin")]
		private string _defaultSkin;

		// Token: 0x040119B9 RID: 72121
		[Token(Token = "0x40119B9")]
		[FieldOffset(Offset = "0x580")]
		[SerializeField]
		[Group("Skin")]
		private MapDependentTrap.SkinEntry[] _skins;

		// Token: 0x040119BA RID: 72122
		[Token(Token = "0x40119BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnAwake;

		// Token: 0x040119BB RID: 72123
		[Token(Token = "0x40119BB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckNeedToLoadSkin;

		// Token: 0x040119BC RID: 72124
		[Token(Token = "0x40119BC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryLoadSkin;

		// Token: 0x040119BD RID: 72125
		[Token(Token = "0x40119BD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002603 RID: 9731
		[Token(Token = "0x2002603")]
		[Serializable]
		public struct SkinEntry
		{
			// Token: 0x0600FD6E RID: 64878 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600FD6E")]
			[Address(RVA = "0x7603E0", Offset = "0x75EFE0", VA = "0x1807603E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x040119BE RID: 72126
			[Token(Token = "0x40119BE")]
			[FieldOffset(Offset = "0x0")]
			public string theme;

			// Token: 0x040119BF RID: 72127
			[Token(Token = "0x40119BF")]
			[FieldOffset(Offset = "0x8")]
			public string skinKey;
		}
	}
}
