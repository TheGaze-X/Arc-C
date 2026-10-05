using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003365 RID: 13157
	[Token(Token = "0x2003365")]
	public class UIHudSimplePlugin : MonoBehaviour, HudPlugin, IHotfixable
	{
		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x06014FF4 RID: 86004 RVA: 0x0008A060 File Offset: 0x00088260
		[Token(Token = "0x170031E0")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014FF4")]
			[Address(RVA = "0xD760C0", Offset = "0xD74CC0", VA = "0x180D760C0", Slot = "4")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x06014FF5 RID: 86005 RVA: 0x0008A078 File Offset: 0x00088278
		[Token(Token = "0x170031E1")]
		public bool needToShow
		{
			[Token(Token = "0x6014FF5")]
			[Address(RVA = "0xD76120", Offset = "0xD74D20", VA = "0x180D76120", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014FF6 RID: 86006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FF6")]
		[Address(RVA = "0xD75E60", Offset = "0xD74A60", VA = "0x180D75E60", Slot = "6")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014FF7 RID: 86007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FF7")]
		[Address(RVA = "0xD75FA0", Offset = "0xD74BA0", VA = "0x180D75FA0", Slot = "7")]
		public void OnDetach()
		{
		}

		// Token: 0x06014FF8 RID: 86008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FF8")]
		[Address(RVA = "0xD76000", Offset = "0xD74C00", VA = "0x180D76000", Slot = "8")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014FF9 RID: 86009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FF9")]
		[Address(RVA = "0xD76060", Offset = "0xD74C60", VA = "0x180D76060")]
		public UIHudSimplePlugin()
		{
		}

		// Token: 0x04018FA1 RID: 102305
		[Token(Token = "0x4018FA1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HudPluginMask _hudMask;

		// Token: 0x04018FA2 RID: 102306
		[Token(Token = "0x4018FA2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _positionHooker;

		// Token: 0x04018FA3 RID: 102307
		[Token(Token = "0x4018FA3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018FA4 RID: 102308
		[Token(Token = "0x4018FA4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018FA5 RID: 102309
		[Token(Token = "0x4018FA5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018FA6 RID: 102310
		[Token(Token = "0x4018FA6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018FA7 RID: 102311
		[Token(Token = "0x4018FA7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018FA8 RID: 102312
		[Token(Token = "0x4018FA8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
