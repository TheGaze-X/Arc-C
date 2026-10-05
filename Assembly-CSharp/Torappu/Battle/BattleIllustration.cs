using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200265E RID: 9822
	[Token(Token = "0x200265E")]
	public class BattleIllustration : MonoBehaviour, IHotfixable
	{
		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x060100FA RID: 65786 RVA: 0x00062190 File Offset: 0x00060390
		[Token(Token = "0x17002306")]
		public bool isValid
		{
			[Token(Token = "0x60100FA")]
			[Address(RVA = "0x7BCB00", Offset = "0x7BB700", VA = "0x1807BCB00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x060100FB RID: 65787 RVA: 0x000621A8 File Offset: 0x000603A8
		// (set) Token: 0x060100FC RID: 65788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002307")]
		[Inspect]
		[ReadOnly]
		public bool folded
		{
			[Token(Token = "0x60100FB")]
			[Address(RVA = "0x7BCAA0", Offset = "0x7BB6A0", VA = "0x1807BCAA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60100FC")]
			[Address(RVA = "0x7BCB90", Offset = "0x7BB790", VA = "0x1807BCB90")]
			set
			{
			}
		}

		// Token: 0x060100FD RID: 65789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60100FD")]
		[Address(RVA = "0x7BC610", Offset = "0x7BB210", VA = "0x1807BC610")]
		public void SetImage(Image image, bool fold)
		{
		}

		// Token: 0x060100FE RID: 65790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60100FE")]
		[Address(RVA = "0x7BC4D0", Offset = "0x7BB0D0", VA = "0x1807BC4D0")]
		public void Clear()
		{
		}

		// Token: 0x060100FF RID: 65791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60100FF")]
		[Address(RVA = "0x7BC7A0", Offset = "0x7BB3A0", VA = "0x1807BC7A0")]
		private void _FoldInternal(bool fold, bool force)
		{
		}

		// Token: 0x06010100 RID: 65792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010100")]
		[Address(RVA = "0x7BC5B0", Offset = "0x7BB1B0", VA = "0x1807BC5B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06010101 RID: 65793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010101")]
		[Address(RVA = "0x7BCA20", Offset = "0x7BB620", VA = "0x1807BCA20")]
		public BattleIllustration()
		{
		}

		// Token: 0x04011DC1 RID: 73153
		[Token(Token = "0x4011DC1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _foldAlpha;

		// Token: 0x04011DC2 RID: 73154
		[Token(Token = "0x4011DC2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector2 _foldOffset;

		// Token: 0x04011DC3 RID: 73155
		[Token(Token = "0x4011DC3")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _foldTime;

		// Token: 0x04011DC4 RID: 73156
		[Token(Token = "0x4011DC4")]
		[FieldOffset(Offset = "0x28")]
		private Image m_image;

		// Token: 0x04011DC5 RID: 73157
		[Token(Token = "0x4011DC5")]
		[FieldOffset(Offset = "0x30")]
		private bool m_fold;

		// Token: 0x04011DC6 RID: 73158
		[Token(Token = "0x4011DC6")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 m_originPos;

		// Token: 0x04011DC7 RID: 73159
		[Token(Token = "0x4011DC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x04011DC8 RID: 73160
		[Token(Token = "0x4011DC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_folded;

		// Token: 0x04011DC9 RID: 73161
		[Token(Token = "0x4011DC9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_folded;

		// Token: 0x04011DCA RID: 73162
		[Token(Token = "0x4011DCA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetImage;

		// Token: 0x04011DCB RID: 73163
		[Token(Token = "0x4011DCB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04011DCC RID: 73164
		[Token(Token = "0x4011DCC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FoldInternal;

		// Token: 0x04011DCD RID: 73165
		[Token(Token = "0x4011DCD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04011DCE RID: 73166
		[Token(Token = "0x4011DCE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
