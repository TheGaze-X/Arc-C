using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034CA RID: 13514
	[Token(Token = "0x20034CA")]
	public class DynIllustEffectHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x06015893 RID: 88211 RVA: 0x0008C838 File Offset: 0x0008AA38
		[Token(Token = "0x170032E7")]
		public DynIllustAction action
		{
			[Token(Token = "0x6015893")]
			[Address(RVA = "0xDFD960", Offset = "0xDFC560", VA = "0x180DFD960")]
			get
			{
				return DynIllustAction.IDLE;
			}
		}

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x06015894 RID: 88212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032E8")]
		public GameObject asset
		{
			[Token(Token = "0x6015894")]
			[Address(RVA = "0xDFD9C0", Offset = "0xDFC5C0", VA = "0x180DFD9C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015895 RID: 88213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015895")]
		[Address(RVA = "0xDFD5F0", Offset = "0xDFC1F0", VA = "0x180DFD5F0")]
		public void InitHolder()
		{
		}

		// Token: 0x06015896 RID: 88214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015896")]
		[Address(RVA = "0xDFD660", Offset = "0xDFC260", VA = "0x180DFD660")]
		public ActionParticle LoadEffect()
		{
			return null;
		}

		// Token: 0x06015897 RID: 88215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015897")]
		[Address(RVA = "0xDFD6D0", Offset = "0xDFC2D0", VA = "0x180DFD6D0")]
		private ActionParticle _LoadEffect()
		{
			return null;
		}

		// Token: 0x06015898 RID: 88216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015898")]
		[Address(RVA = "0xDFD900", Offset = "0xDFC500", VA = "0x180DFD900")]
		public DynIllustEffectHolder()
		{
		}

		// Token: 0x04019D06 RID: 105734
		[Token(Token = "0x4019D06")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _effectPath;

		// Token: 0x04019D07 RID: 105735
		[Token(Token = "0x4019D07")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DynIllustAction _action;

		// Token: 0x04019D08 RID: 105736
		[Token(Token = "0x4019D08")]
		[FieldOffset(Offset = "0x24")]
		private bool m_isLoad;

		// Token: 0x04019D09 RID: 105737
		[Token(Token = "0x4019D09")]
		[FieldOffset(Offset = "0x28")]
		private GameObject m_asset;

		// Token: 0x04019D0A RID: 105738
		[Token(Token = "0x4019D0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_action;

		// Token: 0x04019D0B RID: 105739
		[Token(Token = "0x4019D0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_asset;

		// Token: 0x04019D0C RID: 105740
		[Token(Token = "0x4019D0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitHolder;

		// Token: 0x04019D0D RID: 105741
		[Token(Token = "0x4019D0D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadEffect;

		// Token: 0x04019D0E RID: 105742
		[Token(Token = "0x4019D0E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadEffect;

		// Token: 0x04019D0F RID: 105743
		[Token(Token = "0x4019D0F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
