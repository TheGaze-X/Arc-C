using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu;
using Torappu.UI;
using Torappu.UI.Mission;
using UnityEngine;
using UnityEngine.UI;
using XLua;

// Token: 0x02000075 RID: 117
[Token(Token = "0x2000075")]
public class FifthAnnivExploreMissionObjView : MonoBehaviour, IHotfixable
{
	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700002B")]
	public UIStringEvent onClicked
	{
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x512B80", Offset = "0x511780", VA = "0x180512B80")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x512BE0", Offset = "0x5117E0", VA = "0x180512BE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x511F80", Offset = "0x510B80", VA = "0x180511F80")]
	public void Render(MissionViewModel model)
	{
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x5127D0", Offset = "0x5113D0", VA = "0x1805127D0")]
	private void _RenderItemList(MissionViewModel model)
	{
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x511E60", Offset = "0x510A60", VA = "0x180511E60")]
	public void EventOnClicked()
	{
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x512400", Offset = "0x511000", VA = "0x180512400")]
	private void _EventOnItemClicked(int index)
	{
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x5124E0", Offset = "0x5110E0", VA = "0x1805124E0")]
	private void _InitIfNot()
	{
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x512AC0", Offset = "0x5116C0", VA = "0x180512AC0")]
	public FifthAnnivExploreMissionObjView()
	{
	}

	// Token: 0x040001C9 RID: 457
	[Token(Token = "0x40001C9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _itemCardScale;

	// Token: 0x040001CA RID: 458
	[Token(Token = "0x40001CA")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Color _textDescCompletedColor;

	// Token: 0x040001CB RID: 459
	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Color _textDescInprogressColor;

	// Token: 0x040001CC RID: 460
	[Token(Token = "0x40001CC")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Color _textProgressValueColor;

	// Token: 0x040001CD RID: 461
	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private Color _textProgressTargetColor;

	// Token: 0x040001CE RID: 462
	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text _textDesc;

	// Token: 0x040001CF RID: 463
	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text _textProgress;

	// Token: 0x040001D0 RID: 464
	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Slider _sliderProgress;

	// Token: 0x040001D1 RID: 465
	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject _panelCompleted;

	// Token: 0x040001D2 RID: 466
	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject _panelInprogress;

	// Token: 0x040001D3 RID: 467
	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject _imageRewardGot;

	// Token: 0x040001D4 RID: 468
	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Button _buttonSelf;

	// Token: 0x040001D5 RID: 469
	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private List<GameObject> _notHaveImgList;

	// Token: 0x040001D6 RID: 470
	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Group("Container")]
	private List<RectTransform> _itemContainerList;

	// Token: 0x040001D7 RID: 471
	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0xA8")]
	private string m_missionId;

	// Token: 0x040001D8 RID: 472
	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0xB0")]
	private List<UIItemCard> m_itemCardList;

	// Token: 0x040001D9 RID: 473
	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_isInited;

	// Token: 0x040001DA RID: 474
	[Token(Token = "0x40001DA")]
	private const string COLORED_PROGRESS_TEXT_FORMAT = "<color=#{0}>{1}</color>/<color=#{2}>{3}</color>";

	// Token: 0x040001DC RID: 476
	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x0")]
	private static DelegateBridge __Hotfix0_get_onClicked;

	// Token: 0x040001DD RID: 477
	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x8")]
	private static DelegateBridge __Hotfix0_set_onClicked;

	// Token: 0x040001DE RID: 478
	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0x10")]
	private static DelegateBridge __Hotfix0_Render;

	// Token: 0x040001DF RID: 479
	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0x18")]
	private static DelegateBridge __Hotfix0__RenderItemList;

	// Token: 0x040001E0 RID: 480
	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x20")]
	private static DelegateBridge __Hotfix0_EventOnClicked;

	// Token: 0x040001E1 RID: 481
	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x28")]
	private static DelegateBridge __Hotfix0__EventOnItemClicked;

	// Token: 0x040001E2 RID: 482
	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x30")]
	private static DelegateBridge __Hotfix0__InitIfNot;

	// Token: 0x040001E3 RID: 483
	[Token(Token = "0x40001E3")]
	[FieldOffset(Offset = "0x38")]
	private static DelegateBridge _c__Hotfix0_ctor;
}
