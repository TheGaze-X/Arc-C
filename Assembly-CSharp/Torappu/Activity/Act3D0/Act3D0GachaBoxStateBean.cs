using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007423 RID: 29731
	[Token(Token = "0x2007423")]
	public class Act3D0GachaBoxStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x17006316 RID: 25366
		// (get) Token: 0x06029F86 RID: 171910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006316")]
		public Act3D0Data act3d0Data
		{
			[Token(Token = "0x6029F86")]
			[Address(RVA = "0x258C7A0", Offset = "0x258B3A0", VA = "0x18258C7A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029F87 RID: 171911 RVA: 0x000D7148 File Offset: 0x000D5348
		[Token(Token = "0x6029F87")]
		[Address(RVA = "0x258B860", Offset = "0x258A460", VA = "0x18258B860")]
		public int CheckRemainCount(string boxId, string goodId, PlayerActivity.PlayerAct3D0Activity actInfo, int defaultValue)
		{
			return 0;
		}

		// Token: 0x06029F88 RID: 171912 RVA: 0x000D7160 File Offset: 0x000D5360
		[Token(Token = "0x6029F88")]
		[Address(RVA = "0x258B740", Offset = "0x258A340", VA = "0x18258B740")]
		public bool CheckBoxInfi(string boxId)
		{
			return default(bool);
		}

		// Token: 0x06029F89 RID: 171913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F89")]
		[Address(RVA = "0x258B990", Offset = "0x258A590", VA = "0x18258B990")]
		public void InitInfo(string actId)
		{
		}

		// Token: 0x06029F8A RID: 171914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F8A")]
		[Address(RVA = "0x258C740", Offset = "0x258B340", VA = "0x18258C740")]
		public Act3D0GachaBoxStateBean()
		{
		}

		// Token: 0x0403C2C1 RID: 246465
		[Token(Token = "0x403C2C1")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Dictionary<string, Act3D0Data.InfinitePoolPercent> percent;

		// Token: 0x0403C2C2 RID: 246466
		[Token(Token = "0x403C2C2")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<Act3D0GachaBoxInfo> gachaBoxInfo;

		// Token: 0x0403C2C3 RID: 246467
		[Token(Token = "0x403C2C3")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public string defaultBoxId;

		// Token: 0x0403C2C4 RID: 246468
		[Token(Token = "0x403C2C4")]
		[FieldOffset(Offset = "0x30")]
		private string m_actId;

		// Token: 0x0403C2C5 RID: 246469
		[Token(Token = "0x403C2C5")]
		[FieldOffset(Offset = "0x38")]
		private string m_faction;

		// Token: 0x0403C2C6 RID: 246470
		[Token(Token = "0x403C2C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_act3d0Data;

		// Token: 0x0403C2C7 RID: 246471
		[Token(Token = "0x403C2C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckRemainCount;

		// Token: 0x0403C2C8 RID: 246472
		[Token(Token = "0x403C2C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckBoxInfi;

		// Token: 0x0403C2C9 RID: 246473
		[Token(Token = "0x403C2C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitInfo;

		// Token: 0x0403C2CA RID: 246474
		[Token(Token = "0x403C2CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
