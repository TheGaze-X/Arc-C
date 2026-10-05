using System;
using Il2CppDummyDll;
using Torappu.Mission;
using UnityEngine;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x020048A2 RID: 18594
	[Token(Token = "0x20048A2")]
	public class MissionBookViewBase : MonoBehaviour, MissionBookTagTab.IParentView, IHotfixable
	{
		// Token: 0x0601C0EA RID: 114922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0EA")]
		[Address(RVA = "0x1569B00", Offset = "0x1568700", VA = "0x181569B00", Slot = "5")]
		public virtual void Init(MissionModel model, MissionPageType? initMissionType)
		{
		}

		// Token: 0x0601C0EB RID: 114923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0EB")]
		[Address(RVA = "0x1569A80", Offset = "0x1568680", VA = "0x181569A80", Slot = "6")]
		public virtual void DealWithState(int index, bool isInit)
		{
		}

		// Token: 0x0601C0EC RID: 114924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0EC")]
		[Address(RVA = "0x156B140", Offset = "0x1569D40", VA = "0x18156B140")]
		public MissionBookViewBase()
		{
		}

		// Token: 0x04024A44 RID: 150084
		[Token(Token = "0x4024A44")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04024A45 RID: 150085
		[Token(Token = "0x4024A45")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DealWithState;

		// Token: 0x04024A46 RID: 150086
		[Token(Token = "0x4024A46")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
