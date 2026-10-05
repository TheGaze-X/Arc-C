using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.FunLive
{
	// Token: 0x02002690 RID: 9872
	[Token(Token = "0x2002690")]
	public class FunLiveUIBattleTopBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x060101EE RID: 66030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101EE")]
		[Address(RVA = "0x7E9640", Offset = "0x7E8240", VA = "0x1807E9640")]
		public void InitData(BattleController controller, FunLiveUIPlugin plugin)
		{
		}

		// Token: 0x060101EF RID: 66031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101EF")]
		[Address(RVA = "0x7E9AF0", Offset = "0x7E86F0", VA = "0x1807E9AF0")]
		public void UpdateData(BattleController controller)
		{
		}

		// Token: 0x060101F0 RID: 66032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101F0")]
		[Address(RVA = "0x7E9FD0", Offset = "0x7E8BD0", VA = "0x1807E9FD0")]
		private void _SetRemainTimeInfo()
		{
		}

		// Token: 0x060101F1 RID: 66033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101F1")]
		[Address(RVA = "0x7E9D70", Offset = "0x7E8970", VA = "0x1807E9D70")]
		private void _OnPhotoShoted(object arg)
		{
		}

		// Token: 0x060101F2 RID: 66034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101F2")]
		[Address(RVA = "0x7EA280", Offset = "0x7E8E80", VA = "0x1807EA280")]
		public FunLiveUIBattleTopBar()
		{
		}

		// Token: 0x04011F6B RID: 73579
		[Token(Token = "0x4011F6B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Time")]
		private Text _remainTimeText;

		// Token: 0x04011F6C RID: 73580
		[Token(Token = "0x4011F6C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Time")]
		private GameObject _blueBackground;

		// Token: 0x04011F6D RID: 73581
		[Token(Token = "0x4011F6D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Time")]
		private GameObject _redBackground;

		// Token: 0x04011F6E RID: 73582
		[Token(Token = "0x4011F6E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("TopBar")]
		private Text _photoCnt;

		// Token: 0x04011F6F RID: 73583
		[Token(Token = "0x4011F6F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("TopBar")]
		private Sprite _sysMenuButton;

		// Token: 0x04011F70 RID: 73584
		[Token(Token = "0x4011F70")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("TopBar")]
		private Button _photoLibButton;

		// Token: 0x04011F71 RID: 73585
		[Token(Token = "0x4011F71")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _panelImage;

		// Token: 0x04011F72 RID: 73586
		[Token(Token = "0x4011F72")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _tweenTime;

		// Token: 0x04011F73 RID: 73587
		[Token(Token = "0x4011F73")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Color _tweenColor;

		// Token: 0x04011F74 RID: 73588
		[Token(Token = "0x4011F74")]
		[FieldOffset(Offset = "0x64")]
		private int m_remainTime;

		// Token: 0x04011F75 RID: 73589
		[Token(Token = "0x4011F75")]
		[FieldOffset(Offset = "0x68")]
		private Color m_originColor;

		// Token: 0x04011F76 RID: 73590
		[Token(Token = "0x4011F76")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_tween;

		// Token: 0x04011F77 RID: 73591
		[Token(Token = "0x4011F77")]
		[FieldOffset(Offset = "0x80")]
		private FunLiveUIPlugin m_plugin;

		// Token: 0x04011F78 RID: 73592
		[Token(Token = "0x4011F78")]
		[FieldOffset(Offset = "0x88")]
		private GameModeFactory.FunLiveGameMode m_gameMode;

		// Token: 0x04011F79 RID: 73593
		[Token(Token = "0x4011F79")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04011F7A RID: 73594
		[Token(Token = "0x4011F7A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04011F7B RID: 73595
		[Token(Token = "0x4011F7B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetRemainTimeInfo;

		// Token: 0x04011F7C RID: 73596
		[Token(Token = "0x4011F7C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnPhotoShoted;

		// Token: 0x04011F7D RID: 73597
		[Token(Token = "0x4011F7D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
