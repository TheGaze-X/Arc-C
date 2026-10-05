using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BD4 RID: 27604
	[Token(Token = "0x2006BD4")]
	public class ArchivePicContentDataBinder : DataBinder<PicProperty>
	{
		// Token: 0x060276C4 RID: 161476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276C4")]
		[Address(RVA = "0x2298C10", Offset = "0x2297810", VA = "0x182298C10", Slot = "7")]
		public override void OnValueChanged(PicProperty property)
		{
		}

		// Token: 0x060276C5 RID: 161477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276C5")]
		[Address(RVA = "0x2298E00", Offset = "0x2297A00", VA = "0x182298E00")]
		private void _RefreshLeftImage(bool samePic)
		{
		}

		// Token: 0x060276C6 RID: 161478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60276C6")]
		[Address(RVA = "0x2298D10", Offset = "0x2297910", VA = "0x182298D10")]
		private string _GetPicPath(ActArchiveResData.PicArchiveResItemData picItemData)
		{
			return null;
		}

		// Token: 0x060276C7 RID: 161479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276C7")]
		[Address(RVA = "0x2299310", Offset = "0x2297F10", VA = "0x182299310")]
		public ArchivePicContentDataBinder()
		{
		}

		// Token: 0x04037DAB RID: 228779
		[Token(Token = "0x4037DAB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _mainImg;

		// Token: 0x04037DAC RID: 228780
		[Token(Token = "0x4037DAC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIDynImage _mainImgLoader;

		// Token: 0x04037DAD RID: 228781
		[Token(Token = "0x4037DAD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _mainImgDesc;

		// Token: 0x04037DAE RID: 228782
		[Token(Token = "0x4037DAE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _kvSetPanel;

		// Token: 0x04037DAF RID: 228783
		[Token(Token = "0x4037DAF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _btnSetKV;

		// Token: 0x04037DB0 RID: 228784
		[Token(Token = "0x4037DB0")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedPicItem;

		// Token: 0x04037DB1 RID: 228785
		[Token(Token = "0x4037DB1")]
		[FieldOffset(Offset = "0x50")]
		private ArchivePicModel m_cachedModel;

		// Token: 0x04037DB2 RID: 228786
		[Token(Token = "0x4037DB2")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_tween;

		// Token: 0x04037DB3 RID: 228787
		[Token(Token = "0x4037DB3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037DB4 RID: 228788
		[Token(Token = "0x4037DB4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RefreshLeftImage;

		// Token: 0x04037DB5 RID: 228789
		[Token(Token = "0x4037DB5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetPicPath;

		// Token: 0x04037DB6 RID: 228790
		[Token(Token = "0x4037DB6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
