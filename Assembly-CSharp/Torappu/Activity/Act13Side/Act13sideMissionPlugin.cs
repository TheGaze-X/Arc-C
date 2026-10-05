using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A38 RID: 31288
	[Token(Token = "0x2007A38")]
	public class Act13sideMissionPlugin : MonoBehaviour, TemplateActivityMissionPlugin, IHotfixable
	{
		// Token: 0x0602BD6C RID: 179564 RVA: 0x000DD628 File Offset: 0x000DB828
		[Token(Token = "0x602BD6C")]
		[Address(RVA = "0x27CD460", Offset = "0x27CC060", VA = "0x1827CD460")]
		private static bool _CheckSame(TemplateMissionViewModel missionData1, TemplateMissionViewModel missionData2)
		{
			return default(bool);
		}

		// Token: 0x0602BD6D RID: 179565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD6D")]
		[Address(RVA = "0x27CC5E0", Offset = "0x27CB1E0", VA = "0x1827CC5E0", Slot = "4")]
		public void ApplyDataBundle(TemplateMissionViewModel missionData)
		{
		}

		// Token: 0x0602BD6E RID: 179566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD6E")]
		[Address(RVA = "0x27CCCC0", Offset = "0x27CB8C0", VA = "0x1827CCCC0")]
		public void RenderViewAct13Side()
		{
		}

		// Token: 0x0602BD6F RID: 179567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD6F")]
		[Address(RVA = "0x27CD590", Offset = "0x27CC190", VA = "0x1827CD590")]
		private void _PlayAnim(Action commonRender)
		{
		}

		// Token: 0x0602BD70 RID: 179568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BD70")]
		[Address(RVA = "0x27CC9F0", Offset = "0x27CB5F0", VA = "0x1827CC9F0")]
		private IEnumerator RenderCor(Action commonRender)
		{
			return null;
		}

		// Token: 0x0602BD71 RID: 179569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD71")]
		[Address(RVA = "0x27CD250", Offset = "0x27CBE50", VA = "0x1827CD250")]
		public void Render(Action commonRender)
		{
		}

		// Token: 0x0602BD72 RID: 179570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD72")]
		[Address(RVA = "0x27CCAC0", Offset = "0x27CB6C0", VA = "0x1827CCAC0", Slot = "5")]
		public void RenderCoro(Action commonRender)
		{
		}

		// Token: 0x0602BD73 RID: 179571 RVA: 0x000DD640 File Offset: 0x000DB840
		[Token(Token = "0x602BD73")]
		[Address(RVA = "0x27CC790", Offset = "0x27CB390", VA = "0x1827CC790", Slot = "6")]
		public bool IsAvailClick()
		{
			return default(bool);
		}

		// Token: 0x0602BD74 RID: 179572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD74")]
		[Address(RVA = "0x27CC7F0", Offset = "0x27CB3F0", VA = "0x1827CC7F0")]
		public void OnAllClick()
		{
		}

		// Token: 0x0602BD75 RID: 179573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD75")]
		[Address(RVA = "0x27CC940", Offset = "0x27CB540", VA = "0x1827CC940")]
		public void OnReceiveAllClick()
		{
		}

		// Token: 0x0602BD76 RID: 179574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD76")]
		[Address(RVA = "0x27CC8A0", Offset = "0x27CB4A0", VA = "0x1827CC8A0")]
		public void OnGoToStageClick()
		{
		}

		// Token: 0x0602BD77 RID: 179575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD77")]
		[Address(RVA = "0x27CD650", Offset = "0x27CC250", VA = "0x1827CD650")]
		public Act13sideMissionPlugin()
		{
		}

		// Token: 0x0403F762 RID: 259938
		[Token(Token = "0x403F762")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _missionName;

		// Token: 0x0403F763 RID: 259939
		[Token(Token = "0x403F763")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _missionFinishDesc;

		// Token: 0x0403F764 RID: 259940
		[Token(Token = "0x403F764")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _charBack;

		// Token: 0x0403F765 RID: 259941
		[Token(Token = "0x403F765")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _missionFrom;

		// Token: 0x0403F766 RID: 259942
		[Token(Token = "0x403F766")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _orgDesc;

		// Token: 0x0403F767 RID: 259943
		[Token(Token = "0x403F767")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationWrapper _wrapper;

		// Token: 0x0403F768 RID: 259944
		[Token(Token = "0x403F768")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _leftImg;

		// Token: 0x0403F769 RID: 259945
		[Token(Token = "0x403F769")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _receiveAllBtn;

		// Token: 0x0403F76A RID: 259946
		[Token(Token = "0x403F76A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _showAllBtn;

		// Token: 0x0403F76B RID: 259947
		[Token(Token = "0x403F76B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _emptyPart;

		// Token: 0x0403F76C RID: 259948
		[Token(Token = "0x403F76C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _normalPart;

		// Token: 0x0403F76D RID: 259949
		[Token(Token = "0x403F76D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _allFinishPart;

		// Token: 0x0403F76E RID: 259950
		[Token(Token = "0x403F76E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _goToButton;

		// Token: 0x0403F76F RID: 259951
		[Token(Token = "0x403F76F")]
		[FieldOffset(Offset = "0x80")]
		private bool cacheAvail;

		// Token: 0x0403F770 RID: 259952
		[Token(Token = "0x403F770")]
		private const string FADE_IN_PARAM = "fade_in";

		// Token: 0x0403F771 RID: 259953
		[Token(Token = "0x403F771")]
		private const string FADE_OUT_PARAM = "fade_out";

		// Token: 0x0403F772 RID: 259954
		[Token(Token = "0x403F772")]
		[FieldOffset(Offset = "0x81")]
		private bool m_lockFlag;

		// Token: 0x0403F773 RID: 259955
		[Token(Token = "0x403F773")]
		[FieldOffset(Offset = "0x88")]
		private TemplateMissionViewModel m_cacheViewModel;

		// Token: 0x0403F774 RID: 259956
		[Token(Token = "0x403F774")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public float animDelta;

		// Token: 0x0403F775 RID: 259957
		[Token(Token = "0x403F775")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public Action<string> missionGroupClick;

		// Token: 0x0403F776 RID: 259958
		[Token(Token = "0x403F776")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public Action<string> receiveAllMissionGroupClick;

		// Token: 0x0403F777 RID: 259959
		[Token(Token = "0x403F777")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public bool showAllInfoFlag;

		// Token: 0x0403F778 RID: 259960
		[Token(Token = "0x403F778")]
		[FieldOffset(Offset = "0xA9")]
		private bool m_needToPlayAnim;

		// Token: 0x0403F779 RID: 259961
		[Token(Token = "0x403F779")]
		[FieldOffset(Offset = "0xAA")]
		private bool m_lastTimeData;

		// Token: 0x0403F77A RID: 259962
		[Token(Token = "0x403F77A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CheckSame;

		// Token: 0x0403F77B RID: 259963
		[Token(Token = "0x403F77B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x0403F77C RID: 259964
		[Token(Token = "0x403F77C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderViewAct13Side;

		// Token: 0x0403F77D RID: 259965
		[Token(Token = "0x403F77D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0403F77E RID: 259966
		[Token(Token = "0x403F77E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderCor;

		// Token: 0x0403F77F RID: 259967
		[Token(Token = "0x403F77F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F780 RID: 259968
		[Token(Token = "0x403F780")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RenderCoro;

		// Token: 0x0403F781 RID: 259969
		[Token(Token = "0x403F781")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsAvailClick;

		// Token: 0x0403F782 RID: 259970
		[Token(Token = "0x403F782")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnAllClick;

		// Token: 0x0403F783 RID: 259971
		[Token(Token = "0x403F783")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnReceiveAllClick;

		// Token: 0x0403F784 RID: 259972
		[Token(Token = "0x403F784")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnGoToStageClick;

		// Token: 0x0403F785 RID: 259973
		[Token(Token = "0x403F785")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
