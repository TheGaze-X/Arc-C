using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A35 RID: 31285
	[Token(Token = "0x2007A35")]
	public class Act13sideFinishMissionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BD62 RID: 179554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD62")]
		[Address(RVA = "0x27CB290", Offset = "0x27C9E90", VA = "0x1827CB290")]
		private void _RenderView(string actId, string orgId, int index, int total, Act13SideEachMissionInfo eachMissionInfo, Act13SideData.LongTermMissionData data)
		{
		}

		// Token: 0x0602BD63 RID: 179555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD63")]
		[Address(RVA = "0x27CB1B0", Offset = "0x27C9DB0", VA = "0x1827CB1B0")]
		public void RenderInfo(string actId, string orgId, int index, int total, Act13SideEachMissionInfo eachMissionInfo, Act13SideData.LongTermMissionData data)
		{
		}

		// Token: 0x0602BD64 RID: 179556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD64")]
		[Address(RVA = "0x27CB870", Offset = "0x27CA470", VA = "0x1827CB870")]
		public Act13sideFinishMissionView()
		{
		}

		// Token: 0x0403F740 RID: 259904
		[Token(Token = "0x403F740")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _orgIcon;

		// Token: 0x0403F741 RID: 259905
		[Token(Token = "0x403F741")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _orgInfo;

		// Token: 0x0403F742 RID: 259906
		[Token(Token = "0x403F742")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _finishState;

		// Token: 0x0403F743 RID: 259907
		[Token(Token = "0x403F743")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _fromToPart;

		// Token: 0x0403F744 RID: 259908
		[Token(Token = "0x403F744")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _initPer;

		// Token: 0x0403F745 RID: 259909
		[Token(Token = "0x403F745")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _endPer;

		// Token: 0x0403F746 RID: 259910
		[Token(Token = "0x403F746")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _atMaxPart;

		// Token: 0x0403F747 RID: 259911
		[Token(Token = "0x403F747")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _gradeUpPart;

		// Token: 0x0403F748 RID: 259912
		[Token(Token = "0x403F748")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _initGrade;

		// Token: 0x0403F749 RID: 259913
		[Token(Token = "0x403F749")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _endGrade;

		// Token: 0x0403F74A RID: 259914
		[Token(Token = "0x403F74A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _skipPart;

		// Token: 0x0403F74B RID: 259915
		[Token(Token = "0x403F74B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _nextDetail;

		// Token: 0x0403F74C RID: 259916
		[Token(Token = "0x403F74C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _alphaCanvasGroup;

		// Token: 0x0403F74D RID: 259917
		[Token(Token = "0x403F74D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0403F74E RID: 259918
		[Token(Token = "0x403F74E")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public bool isFirstTime;

		// Token: 0x0403F74F RID: 259919
		[Token(Token = "0x403F74F")]
		private const string ANIM_PARAM = "finish_fade_in_anim";

		// Token: 0x0403F750 RID: 259920
		[Token(Token = "0x403F750")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x0403F751 RID: 259921
		[Token(Token = "0x403F751")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderInfo;

		// Token: 0x0403F752 RID: 259922
		[Token(Token = "0x403F752")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
