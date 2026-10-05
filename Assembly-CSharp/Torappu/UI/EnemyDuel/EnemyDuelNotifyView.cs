using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FAB RID: 20395
	[Token(Token = "0x2004FAB")]
	public class EnemyDuelNotifyView : UINotifyView<EnemyDuelNotifyView.Param>
	{
		// Token: 0x0601E4E9 RID: 124137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4E9")]
		[Address(RVA = "0x1807030", Offset = "0x1805C30", VA = "0x181807030", Slot = "9")]
		protected override void Render(EnemyDuelNotifyView.Param param)
		{
		}

		// Token: 0x0601E4EA RID: 124138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4EA")]
		[Address(RVA = "0x1807140", Offset = "0x1805D40", VA = "0x181807140")]
		public EnemyDuelNotifyView()
		{
		}

		// Token: 0x0402876E RID: 165742
		[Token(Token = "0x402876E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtNotify;

		// Token: 0x0402876F RID: 165743
		[Token(Token = "0x402876F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _image;

		// Token: 0x04028770 RID: 165744
		[Token(Token = "0x4028770")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028771 RID: 165745
		[Token(Token = "0x4028771")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FAC RID: 20396
		[Token(Token = "0x2004FAC")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0601E4EB RID: 124139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E4EB")]
			[Address(RVA = "0x180C170", Offset = "0x180AD70", VA = "0x18180C170", Slot = "4")]
			public override string GenerateSignature()
			{
				return null;
			}

			// Token: 0x0601E4EC RID: 124140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4EC")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x04028772 RID: 165746
			[Token(Token = "0x4028772")]
			[FieldOffset(Offset = "0x10")]
			public string notifyTips;

			// Token: 0x04028773 RID: 165747
			[Token(Token = "0x4028773")]
			[FieldOffset(Offset = "0x18")]
			public bool isStrongAlert;
		}
	}
}
