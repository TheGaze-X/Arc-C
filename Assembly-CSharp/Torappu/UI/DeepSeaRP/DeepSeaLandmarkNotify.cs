using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200511A RID: 20762
	[Token(Token = "0x200511A")]
	public class DeepSeaLandmarkNotify : UINotifyView<DeepSeaLandmarkNotify.Param>
	{
		// Token: 0x0601EA99 RID: 125593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA99")]
		[Address(RVA = "0x184F5B0", Offset = "0x184E1B0", VA = "0x18184F5B0", Slot = "9")]
		protected override void Render(DeepSeaLandmarkNotify.Param param)
		{
		}

		// Token: 0x0601EA9A RID: 125594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA9A")]
		[Address(RVA = "0x184F680", Offset = "0x184E280", VA = "0x18184F680")]
		public DeepSeaLandmarkNotify()
		{
		}

		// Token: 0x040291EB RID: 168427
		[Token(Token = "0x40291EB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x040291EC RID: 168428
		[Token(Token = "0x40291EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040291ED RID: 168429
		[Token(Token = "0x40291ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200511B RID: 20763
		[Token(Token = "0x200511B")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0601EA9B RID: 125595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA9B")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x040291EE RID: 168430
			[Token(Token = "0x40291EE")]
			[FieldOffset(Offset = "0x10")]
			public string name;
		}
	}
}
