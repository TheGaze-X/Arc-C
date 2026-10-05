using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E5E RID: 28254
	[Token(Token = "0x2006E5E")]
	public class ActVecBreakV2OffenseStageRaidView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028358 RID: 164696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028358")]
		[Address(RVA = "0x2379370", Offset = "0x2377F70", VA = "0x182379370")]
		public void Render(VecBreakV2OffenseRaidStageModel stageModel, bool isSelected)
		{
		}

		// Token: 0x06028359 RID: 164697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028359")]
		[Address(RVA = "0x2379280", Offset = "0x2377E80", VA = "0x182379280")]
		public void OnClickStageInfo()
		{
		}

		// Token: 0x0602835A RID: 164698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602835A")]
		[Address(RVA = "0x23798B0", Offset = "0x23784B0", VA = "0x1823798B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602835B RID: 164699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602835B")]
		[Address(RVA = "0x2379C90", Offset = "0x2378890", VA = "0x182379C90")]
		private void _RenderCompleteStatus(bool isCompleted)
		{
		}

		// Token: 0x0602835C RID: 164700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602835C")]
		[Address(RVA = "0x2379E90", Offset = "0x2378A90", VA = "0x182379E90")]
		private void _RenderStageTitle(string code, string name)
		{
		}

		// Token: 0x0602835D RID: 164701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602835D")]
		[Address(RVA = "0x2379A10", Offset = "0x2378610", VA = "0x182379A10")]
		private void _RenderAlphaOrder(ActVecBreakV2StageOrderType orderType, bool isCompleted)
		{
		}

		// Token: 0x0602835E RID: 164702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602835E")]
		[Address(RVA = "0x2379B50", Offset = "0x2378750", VA = "0x182379B50")]
		private void _RenderBossIcon(string bossDecoId)
		{
		}

		// Token: 0x0602835F RID: 164703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602835F")]
		[Address(RVA = "0x2379F90", Offset = "0x2378B90", VA = "0x182379F90")]
		public ActVecBreakV2OffenseStageRaidView()
		{
		}

		// Token: 0x0403921B RID: 234011
		[Token(Token = "0x403921B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _normalGos;

		// Token: 0x0403921C RID: 234012
		[Token(Token = "0x403921C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _doneGos;

		// Token: 0x0403921D RID: 234013
		[Token(Token = "0x403921D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _bgImg;

		// Token: 0x0403921E RID: 234014
		[Token(Token = "0x403921E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _bgNormalColor;

		// Token: 0x0403921F RID: 234015
		[Token(Token = "0x403921F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _bgDoneColor;

		// Token: 0x04039220 RID: 234016
		[Token(Token = "0x4039220")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _titleIcon;

		// Token: 0x04039221 RID: 234017
		[Token(Token = "0x4039221")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x04039222 RID: 234018
		[Token(Token = "0x4039222")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _titleTextNormalColor;

		// Token: 0x04039223 RID: 234019
		[Token(Token = "0x4039223")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _titleTextDoneColor;

		// Token: 0x04039224 RID: 234020
		[Token(Token = "0x4039224")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _bossDecoIcon;

		// Token: 0x04039225 RID: 234021
		[Token(Token = "0x4039225")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup _selectedCanvasGroup;

		// Token: 0x04039226 RID: 234022
		[Token(Token = "0x4039226")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _newTrackRoot;

		// Token: 0x04039227 RID: 234023
		[Token(Token = "0x4039227")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _newTrackPoint;

		// Token: 0x04039228 RID: 234024
		[Token(Token = "0x4039228")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x04039229 RID: 234025
		[Token(Token = "0x4039229")]
		[FieldOffset(Offset = "0xA8")]
		private string m_cachedOrderId;

		// Token: 0x0403922A RID: 234026
		[Token(Token = "0x403922A")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedBossDecoId;

		// Token: 0x0403922B RID: 234027
		[Token(Token = "0x403922B")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject m_newTrackPoint;

		// Token: 0x0403922C RID: 234028
		[Token(Token = "0x403922C")]
		[FieldOffset(Offset = "0xC0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403922D RID: 234029
		[Token(Token = "0x403922D")]
		[FieldOffset(Offset = "0xD0")]
		private FadeSwitchTween m_selectTween;

		// Token: 0x0403922E RID: 234030
		[Token(Token = "0x403922E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403922F RID: 234031
		[Token(Token = "0x403922F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickStageInfo;

		// Token: 0x04039230 RID: 234032
		[Token(Token = "0x4039230")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039231 RID: 234033
		[Token(Token = "0x4039231")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderCompleteStatus;

		// Token: 0x04039232 RID: 234034
		[Token(Token = "0x4039232")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderStageTitle;

		// Token: 0x04039233 RID: 234035
		[Token(Token = "0x4039233")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderAlphaOrder;

		// Token: 0x04039234 RID: 234036
		[Token(Token = "0x4039234")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderBossIcon;

		// Token: 0x04039235 RID: 234037
		[Token(Token = "0x4039235")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
