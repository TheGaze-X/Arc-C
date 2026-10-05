using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EB7 RID: 16055
	[Token(Token = "0x2003EB7")]
	public class SocialCardAlbumPage : StateEnginePage, IFadeInPushWithBlurBkg, IHotfixable, IValueMsgReceiver
	{
		// Token: 0x17003B74 RID: 15220
		// (get) Token: 0x06018EC2 RID: 102082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003B74")]
		public SocialCardAlbumProperty property
		{
			[Token(Token = "0x6018EC2")]
			[Address(RVA = "0x11A7F40", Offset = "0x11A6B40", VA = "0x1811A7F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018EC3 RID: 102083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018EC3")]
		[Address(RVA = "0x11A7650", Offset = "0x11A6250", VA = "0x1811A7650", Slot = "29")]
		public UIRenderTextureImage GetBlurBkg()
		{
			return null;
		}

		// Token: 0x06018EC4 RID: 102084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EC4")]
		[Address(RVA = "0x11A7A30", Offset = "0x11A6630", VA = "0x1811A7A30", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x06018EC5 RID: 102085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018EC5")]
		[Address(RVA = "0x11A76B0", Offset = "0x11A62B0", VA = "0x1811A76B0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x06018EC6 RID: 102086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EC6")]
		[Address(RVA = "0x11A7760", Offset = "0x11A6360", VA = "0x1811A7760", Slot = "30")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06018EC7 RID: 102087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EC7")]
		[Address(RVA = "0x11A7BE0", Offset = "0x11A67E0", VA = "0x1811A7BE0")]
		private void _EnsureExposureTracker()
		{
		}

		// Token: 0x06018EC8 RID: 102088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EC8")]
		[Address(RVA = "0x11A7CB0", Offset = "0x11A68B0", VA = "0x1811A7CB0")]
		private void _RegisterExposureView(object objVal)
		{
		}

		// Token: 0x06018EC9 RID: 102089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EC9")]
		[Address(RVA = "0x11A7E70", Offset = "0x11A6A70", VA = "0x1811A7E70")]
		private void _TickExposureTracker()
		{
		}

		// Token: 0x06018ECA RID: 102090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018ECA")]
		[Address(RVA = "0x11A7EE0", Offset = "0x11A6AE0", VA = "0x1811A7EE0")]
		public SocialCardAlbumPage()
		{
		}

		// Token: 0x06018ECC RID: 102092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018ECC")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06018ECD RID: 102093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018ECD")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x0401EC11 RID: 125969
		[Token(Token = "0x401EC11")]
		[NonSerialized]
		public const int EVENT_REGISTER_EXPOSURE_VIEW = 0;

		// Token: 0x0401EC12 RID: 125970
		[Token(Token = "0x401EC12")]
		[NonSerialized]
		public const int EVENT_TICK_EXPOSURE_TRACKER = 1;

		// Token: 0x0401EC13 RID: 125971
		[Token(Token = "0x401EC13")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIRenderTextureImage _blurBackgroundImage;

		// Token: 0x0401EC14 RID: 125972
		[Token(Token = "0x401EC14")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _exposeViewPort;

		// Token: 0x0401EC15 RID: 125973
		[Token(Token = "0x401EC15")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private float _exposePercent;

		// Token: 0x0401EC16 RID: 125974
		[Token(Token = "0x401EC16")]
		[FieldOffset(Offset = "0x108")]
		private SocialCardAlbumProperty m_property;

		// Token: 0x0401EC17 RID: 125975
		[Token(Token = "0x401EC17")]
		[FieldOffset(Offset = "0x110")]
		private ExposureTracker m_exposureTracker;

		// Token: 0x0401EC18 RID: 125976
		[Token(Token = "0x401EC18")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_property;

		// Token: 0x0401EC19 RID: 125977
		[Token(Token = "0x401EC19")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurBkg;

		// Token: 0x0401EC1A RID: 125978
		[Token(Token = "0x401EC1A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0401EC1B RID: 125979
		[Token(Token = "0x401EC1B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x0401EC1C RID: 125980
		[Token(Token = "0x401EC1C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401EC1D RID: 125981
		[Token(Token = "0x401EC1D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EnsureExposureTracker;

		// Token: 0x0401EC1E RID: 125982
		[Token(Token = "0x401EC1E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RegisterExposureView;

		// Token: 0x0401EC1F RID: 125983
		[Token(Token = "0x401EC1F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TickExposureTracker;

		// Token: 0x0401EC20 RID: 125984
		[Token(Token = "0x401EC20")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003EB8 RID: 16056
		[Token(Token = "0x2003EB8")]
		public class Param
		{
			// Token: 0x06018ECE RID: 102094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018ECE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0401EC21 RID: 125985
			[Token(Token = "0x401EC21")]
			[FieldOffset(Offset = "0x10")]
			public bool isSelf;

			// Token: 0x0401EC22 RID: 125986
			[Token(Token = "0x401EC22")]
			[FieldOffset(Offset = "0x18")]
			public FriendDataWithNameCard friendData;
		}
	}
}
