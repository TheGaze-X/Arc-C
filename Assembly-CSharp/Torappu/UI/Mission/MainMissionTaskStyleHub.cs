using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x0200489C RID: 18588
	[Token(Token = "0x200489C")]
	[CreateAssetMenu(menuName = "Torappu/UI/Business/MainMissionTaskStyleHub")]
	public class MainMissionTaskStyleHub : ScriptableObject, IHotfixable
	{
		// Token: 0x0601C0C8 RID: 114888 RVA: 0x000A70D0 File Offset: 0x000A52D0
		[Token(Token = "0x601C0C8")]
		[Address(RVA = "0x15675B0", Offset = "0x15661B0", VA = "0x1815675B0")]
		public MainMissionTaskViewStyleConfig TryGetValue(MainMissionTaskViewStyleBaseInfo key)
		{
			return default(MainMissionTaskViewStyleConfig);
		}

		// Token: 0x0601C0C9 RID: 114889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0C9")]
		[Address(RVA = "0x1567860", Offset = "0x1566460", VA = "0x181567860")]
		public MainMissionTaskStyleHub()
		{
		}

		// Token: 0x04024A06 RID: 150022
		[Token(Token = "0x4024A06")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<MainMissionTaskViewStyleConfig> _configs;

		// Token: 0x04024A07 RID: 150023
		[Token(Token = "0x4024A07")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetValue;

		// Token: 0x04024A08 RID: 150024
		[Token(Token = "0x4024A08")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
