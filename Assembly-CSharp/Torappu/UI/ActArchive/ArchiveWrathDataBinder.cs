using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C5F RID: 27743
	[Token(Token = "0x2006C5F")]
	public class ArchiveWrathDataBinder : DataBinder<WrathProperty>
	{
		// Token: 0x17005D93 RID: 23955
		// (get) Token: 0x06027994 RID: 162196 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027995 RID: 162197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D93")]
		public ArchiveWrathController controller
		{
			[Token(Token = "0x6027994")]
			[Address(RVA = "0x22C8B10", Offset = "0x22C7710", VA = "0x1822C8B10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027995")]
			[Address(RVA = "0x22C8B70", Offset = "0x22C7770", VA = "0x1822C8B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027996 RID: 162198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027996")]
		[Address(RVA = "0x22C7C70", Offset = "0x22C6870", VA = "0x1822C7C70", Slot = "7")]
		public override void OnValueChanged(WrathProperty property)
		{
		}

		// Token: 0x06027997 RID: 162199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027997")]
		[Address(RVA = "0x22C84C0", Offset = "0x22C70C0", VA = "0x1822C84C0")]
		private void _Render(WrathTypeModel typeModel)
		{
		}

		// Token: 0x06027998 RID: 162200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027998")]
		[Address(RVA = "0x22C8360", Offset = "0x22C6F60", VA = "0x1822C8360")]
		private void _PlayAnim(ArchiveWrathModel.SwitchType type, bool currAttained)
		{
		}

		// Token: 0x06027999 RID: 162201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027999")]
		[Address(RVA = "0x22C8180", Offset = "0x22C6D80", VA = "0x1822C8180")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602799A RID: 162202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602799A")]
		[Address(RVA = "0x22C8AA0", Offset = "0x22C76A0", VA = "0x1822C8AA0")]
		public ArchiveWrathDataBinder()
		{
		}

		// Token: 0x04038288 RID: 230024
		[Token(Token = "0x4038288")]
		private const string ICON_BG_UNLOCK_NAME = "icon_bg_unlock";

		// Token: 0x04038289 RID: 230025
		[Token(Token = "0x4038289")]
		private const string ICON_BG_POSITIVE_NAME = "icon_bg_positive";

		// Token: 0x0403828A RID: 230026
		[Token(Token = "0x403828A")]
		private const string ICON_BG_LOCK_NAME = "icon_bg_lock";

		// Token: 0x0403828B RID: 230027
		[Token(Token = "0x403828B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _title;

		// Token: 0x0403828C RID: 230028
		[Token(Token = "0x403828C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0403828D RID: 230029
		[Token(Token = "0x403828D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403828E RID: 230030
		[Token(Token = "0x403828E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _iconBg;

		// Token: 0x0403828F RID: 230031
		[Token(Token = "0x403828F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x04038290 RID: 230032
		[Token(Token = "0x4038290")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArchiveWrathTypeItemAdapter _typeAdapter;

		// Token: 0x04038291 RID: 230033
		[Token(Token = "0x4038291")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArchiveWrathLevelItemView[] _levels;

		// Token: 0x04038292 RID: 230034
		[Token(Token = "0x4038292")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _animRefresh;

		// Token: 0x04038293 RID: 230035
		[Token(Token = "0x4038293")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _animColor;

		// Token: 0x04038295 RID: 230037
		[Token(Token = "0x4038295")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x04038296 RID: 230038
		[Token(Token = "0x4038296")]
		[FieldOffset(Offset = "0x88")]
		private AnimationSwitchTween m_colorTween;

		// Token: 0x04038297 RID: 230039
		[Token(Token = "0x4038297")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_refreshTween;

		// Token: 0x04038298 RID: 230040
		[Token(Token = "0x4038298")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04038299 RID: 230041
		[Token(Token = "0x4038299")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x0403829A RID: 230042
		[Token(Token = "0x403829A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403829B RID: 230043
		[Token(Token = "0x403829B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403829C RID: 230044
		[Token(Token = "0x403829C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0403829D RID: 230045
		[Token(Token = "0x403829D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403829E RID: 230046
		[Token(Token = "0x403829E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
