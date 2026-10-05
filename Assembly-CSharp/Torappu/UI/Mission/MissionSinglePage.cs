using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x020048A8 RID: 18600
	[Token(Token = "0x20048A8")]
	public abstract class MissionSinglePage : MonoBehaviour, IHotfixable
	{
		// Token: 0x170042A2 RID: 17058
		// (get) Token: 0x0601C110 RID: 114960 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601C111 RID: 114961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170042A2")]
		private protected MissionModel stateBean
		{
			[Token(Token = "0x601C110")]
			[Address(RVA = "0x156D640", Offset = "0x156C240", VA = "0x18156D640")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601C111")]
			[Address(RVA = "0x156D710", Offset = "0x156C310", VA = "0x18156D710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170042A3 RID: 17059
		// (get) Token: 0x0601C112 RID: 114962 RVA: 0x000A71D8 File Offset: 0x000A53D8
		// (set) Token: 0x0601C113 RID: 114963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170042A3")]
		private protected bool isDisplay
		{
			[Token(Token = "0x601C112")]
			[Address(RVA = "0x156D5E0", Offset = "0x156C1E0", VA = "0x18156D5E0")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x601C113")]
			[Address(RVA = "0x156D6A0", Offset = "0x156C2A0", VA = "0x18156D6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601C114 RID: 114964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C114")]
		[Address(RVA = "0x156D160", Offset = "0x156BD60", VA = "0x18156D160")]
		public void InitData(MissionModel stateBean)
		{
		}

		// Token: 0x0601C115 RID: 114965 RVA: 0x000A71F0 File Offset: 0x000A53F0
		[Token(Token = "0x601C115")]
		[Address(RVA = "0x1564210", Offset = "0x1562E10", VA = "0x181564210", Slot = "4")]
		public virtual bool IsToBeShown(MissionModel stateBean)
		{
			return default(bool);
		}

		// Token: 0x0601C116 RID: 114966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C116")]
		[Address(RVA = "0x156D250", Offset = "0x156BE50", VA = "0x18156D250")]
		public void RefreshData(MissionModel stateBean)
		{
		}

		// Token: 0x0601C117 RID: 114967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C117")]
		[Address(RVA = "0x1564280", Offset = "0x1562E80", VA = "0x181564280", Slot = "5")]
		protected virtual void RefreshView()
		{
		}

		// Token: 0x0601C118 RID: 114968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C118")]
		[Address(RVA = "0x156D340", Offset = "0x156BF40", VA = "0x18156D340")]
		public void ToggleDisplay(bool display, bool isInit)
		{
		}

		// Token: 0x0601C119 RID: 114969 RVA: 0x000A7208 File Offset: 0x000A5408
		[Token(Token = "0x601C119")]
		[Address(RVA = "0x156D0B0", Offset = "0x156BCB0", VA = "0x18156D0B0")]
		public bool HasMissionType(MissionType missionType)
		{
			return default(bool);
		}

		// Token: 0x0601C11A RID: 114970 RVA: 0x000A7220 File Offset: 0x000A5420
		[Token(Token = "0x601C11A")]
		[Address(RVA = "0x156D010", Offset = "0x156BC10", VA = "0x18156D010")]
		public MissionType GetDefaultMissionType()
		{
			return MissionType.UNKNOWN;
		}

		// Token: 0x0601C11B RID: 114971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C11B")]
		[Address(RVA = "0x156D500", Offset = "0x156C100", VA = "0x18156D500")]
		private void _OnDislay()
		{
		}

		// Token: 0x0601C11C RID: 114972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C11C")]
		[Address(RVA = "0x156D580", Offset = "0x156C180", VA = "0x18156D580")]
		protected MissionSinglePage()
		{
		}

		// Token: 0x04024A83 RID: 150147
		[Token(Token = "0x4024A83")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected MissionType[] _missionType;

		// Token: 0x04024A86 RID: 150150
		[Token(Token = "0x4024A86")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stateBean;

		// Token: 0x04024A87 RID: 150151
		[Token(Token = "0x4024A87")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_stateBean;

		// Token: 0x04024A88 RID: 150152
		[Token(Token = "0x4024A88")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isDisplay;

		// Token: 0x04024A89 RID: 150153
		[Token(Token = "0x4024A89")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isDisplay;

		// Token: 0x04024A8A RID: 150154
		[Token(Token = "0x4024A8A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04024A8B RID: 150155
		[Token(Token = "0x4024A8B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsToBeShown;

		// Token: 0x04024A8C RID: 150156
		[Token(Token = "0x4024A8C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04024A8D RID: 150157
		[Token(Token = "0x4024A8D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshView;

		// Token: 0x04024A8E RID: 150158
		[Token(Token = "0x4024A8E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ToggleDisplay;

		// Token: 0x04024A8F RID: 150159
		[Token(Token = "0x4024A8F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HasMissionType;

		// Token: 0x04024A90 RID: 150160
		[Token(Token = "0x4024A90")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetDefaultMissionType;

		// Token: 0x04024A91 RID: 150161
		[Token(Token = "0x4024A91")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnDislay;

		// Token: 0x04024A92 RID: 150162
		[Token(Token = "0x4024A92")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
