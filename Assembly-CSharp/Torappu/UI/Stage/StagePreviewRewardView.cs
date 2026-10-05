using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Stage
{
	// Token: 0x02006938 RID: 26936
	[Token(Token = "0x2006938")]
	public class StagePreviewRewardView : MonoBehaviour
	{
		// Token: 0x0602692C RID: 157996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602692C")]
		[Address(RVA = "0x21B6220", Offset = "0x21B4E20", VA = "0x1821B6220")]
		public void Init(List<StageRewardDetailViewModel> viewModelList, List<KeyValuePair<string, StageRewardDetailViewModel>> timelyReward, bool getFlag, bool completeFlag)
		{
		}

		// Token: 0x0602692D RID: 157997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602692D")]
		[Address(RVA = "0x21B5F20", Offset = "0x21B4B20", VA = "0x1821B5F20")]
		public void Init(StagePreviewRewardView.Config config)
		{
		}

		// Token: 0x0602692E RID: 157998 RVA: 0x000CBBB0 File Offset: 0x000C9DB0
		[Token(Token = "0x602692E")]
		[Address(RVA = "0x21B64F0", Offset = "0x21B50F0", VA = "0x1821B64F0")]
		private bool _CheckGroupViewAvail(List<StageDropType> dropTypeHide, List<StageDropType> dropTypeList)
		{
			return default(bool);
		}

		// Token: 0x0602692F RID: 157999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602692F")]
		[Address(RVA = "0x21B65D0", Offset = "0x21B51D0", VA = "0x1821B65D0")]
		private void _Init(StageRewardDetailPluginHandler pluginHandler, List<StageRewardDetailViewModel> viewModelList, List<KeyValuePair<string, StageRewardDetailViewModel>> timelyReward, bool getFlag, bool completeFlag)
		{
		}

		// Token: 0x06026930 RID: 158000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026930")]
		[Address(RVA = "0x21B6680", Offset = "0x21B5280", VA = "0x1821B6680")]
		private IEnumerator _UpdateLayoutCoroutine()
		{
			return null;
		}

		// Token: 0x06026931 RID: 158001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026931")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public StagePreviewRewardView()
		{
		}

		// Token: 0x04036696 RID: 222870
		[Token(Token = "0x4036696")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<StagePreviewRewardGroupView> _groupViewList;

		// Token: 0x04036697 RID: 222871
		[Token(Token = "0x4036697")]
		[FieldOffset(Offset = "0x20")]
		private StageRewardDetailPluginHandler m_pluginHandler;

		// Token: 0x02006939 RID: 26937
		[Token(Token = "0x2006939")]
		public class Config
		{
			// Token: 0x06026932 RID: 158002 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026932")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Config()
			{
			}

			// Token: 0x04036698 RID: 222872
			[Token(Token = "0x4036698")]
			[FieldOffset(Offset = "0x10")]
			public OverrideDropInfo overrideDropInfo;

			// Token: 0x04036699 RID: 222873
			[Token(Token = "0x4036699")]
			[FieldOffset(Offset = "0x18")]
			public StageRewardDetailPluginHandler pluginHandler;

			// Token: 0x0403669A RID: 222874
			[Token(Token = "0x403669A")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<StageDropType, List<StageRewardDetailViewModel>> viewModelDict;

			// Token: 0x0403669B RID: 222875
			[Token(Token = "0x403669B")]
			[FieldOffset(Offset = "0x28")]
			public List<KeyValuePair<string, StageRewardDetailViewModel>> timelyReward;

			// Token: 0x0403669C RID: 222876
			[Token(Token = "0x403669C")]
			[FieldOffset(Offset = "0x30")]
			public bool isGet;

			// Token: 0x0403669D RID: 222877
			[Token(Token = "0x403669D")]
			[FieldOffset(Offset = "0x31")]
			public bool isComplete;

			// Token: 0x0403669E RID: 222878
			[Token(Token = "0x403669E")]
			[FieldOffset(Offset = "0x38")]
			public List<StageDropType> hideDropType;
		}
	}
}
