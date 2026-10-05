using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005853 RID: 22611
	[Token(Token = "0x2005853")]
	public class RL03ChaosChangeToastView : UINotifyView<RL03ChaosChangeToastView.Param>
	{
		// Token: 0x06021082 RID: 135298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021082")]
		[Address(RVA = "0x1B5C9F0", Offset = "0x1B5B5F0", VA = "0x181B5C9F0", Slot = "9")]
		protected override void Render(RL03ChaosChangeToastView.Param param)
		{
		}

		// Token: 0x06021083 RID: 135299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021083")]
		[Address(RVA = "0x1B5CB50", Offset = "0x1B5B750", VA = "0x181B5CB50")]
		public RL03ChaosChangeToastView()
		{
		}

		// Token: 0x0402CED1 RID: 184017
		[Token(Token = "0x402CED1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelIncrease;

		// Token: 0x0402CED2 RID: 184018
		[Token(Token = "0x402CED2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelDecrease;

		// Token: 0x0402CED3 RID: 184019
		[Token(Token = "0x402CED3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgChaos;

		// Token: 0x0402CED4 RID: 184020
		[Token(Token = "0x402CED4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtChaosName;

		// Token: 0x0402CED5 RID: 184021
		[Token(Token = "0x402CED5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CED6 RID: 184022
		[Token(Token = "0x402CED6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005854 RID: 22612
		[Token(Token = "0x2005854")]
		public class Param : NotifyViewParam
		{
			// Token: 0x06021084 RID: 135300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021084")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0402CED7 RID: 184023
			[Token(Token = "0x402CED7")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0402CED8 RID: 184024
			[Token(Token = "0x402CED8")]
			[FieldOffset(Offset = "0x18")]
			public string chaosIconId;

			// Token: 0x0402CED9 RID: 184025
			[Token(Token = "0x402CED9")]
			[FieldOffset(Offset = "0x20")]
			public string chaosName;

			// Token: 0x0402CEDA RID: 184026
			[Token(Token = "0x402CEDA")]
			[FieldOffset(Offset = "0x28")]
			public bool upgrade;
		}
	}
}
