using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F5F RID: 28511
	[Token(Token = "0x2006F5F")]
	public class ActMultiV3BoardPhotoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060287C5 RID: 165829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287C5")]
		[Address(RVA = "0x23C02A0", Offset = "0x23BEEA0", VA = "0x1823C02A0")]
		public void Render(ActMultiV3PhotoViewModel model)
		{
		}

		// Token: 0x060287C6 RID: 165830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287C6")]
		[Address(RVA = "0x23C01D0", Offset = "0x23BEDD0", VA = "0x1823C01D0")]
		public void OnClickPhoto()
		{
		}

		// Token: 0x060287C7 RID: 165831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287C7")]
		[Address(RVA = "0x23C0580", Offset = "0x23BF180", VA = "0x1823C0580")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060287C8 RID: 165832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287C8")]
		[Address(RVA = "0x23C0680", Offset = "0x23BF280", VA = "0x1823C0680")]
		public ActMultiV3BoardPhotoView()
		{
		}

		// Token: 0x040399A2 RID: 235938
		[Token(Token = "0x40399A2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _filledToggle;

		// Token: 0x040399A3 RID: 235939
		[Token(Token = "0x40399A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _numberText;

		// Token: 0x040399A4 RID: 235940
		[Token(Token = "0x40399A4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _titleDescText;

		// Token: 0x040399A5 RID: 235941
		[Token(Token = "0x40399A5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActMultiV3PhotoView _contentView;

		// Token: 0x040399A6 RID: 235942
		[Token(Token = "0x40399A6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _trackPointContainer;

		// Token: 0x040399A7 RID: 235943
		[Token(Token = "0x40399A7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _trackPointObj;

		// Token: 0x040399A8 RID: 235944
		[Token(Token = "0x40399A8")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x040399A9 RID: 235945
		[Token(Token = "0x40399A9")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedTemplateId;

		// Token: 0x040399AA RID: 235946
		[Token(Token = "0x40399AA")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedInstId;

		// Token: 0x040399AB RID: 235947
		[Token(Token = "0x40399AB")]
		[FieldOffset(Offset = "0x60")]
		private int m_cachedPhotoTypeIdx;

		// Token: 0x040399AC RID: 235948
		[Token(Token = "0x40399AC")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040399AD RID: 235949
		[Token(Token = "0x40399AD")]
		[FieldOffset(Offset = "0x78")]
		private GameObject m_trackPoint;

		// Token: 0x040399AE RID: 235950
		[Token(Token = "0x40399AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040399AF RID: 235951
		[Token(Token = "0x40399AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickPhoto;

		// Token: 0x040399B0 RID: 235952
		[Token(Token = "0x40399B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040399B1 RID: 235953
		[Token(Token = "0x40399B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
