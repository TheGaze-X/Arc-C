using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004ACB RID: 19147
	[Token(Token = "0x2004ACB")]
	public class HotUpdateWriteConfigNode : HotUpdateWorkflow.Node
	{
		// Token: 0x170043DA RID: 17370
		// (get) Token: 0x0601CC0F RID: 117775 RVA: 0x000A9680 File Offset: 0x000A7880
		[Token(Token = "0x170043DA")]
		public override HotUpdateWorkflow.ENode type
		{
			[Token(Token = "0x601CC0F")]
			[Address(RVA = "0x162B9D0", Offset = "0x162A5D0", VA = "0x18162B9D0", Slot = "4")]
			get
			{
				return HotUpdateWorkflow.ENode.NONE;
			}
		}

		// Token: 0x0601CC10 RID: 117776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC10")]
		[Address(RVA = "0x162B620", Offset = "0x162A220", VA = "0x18162B620", Slot = "5")]
		public override CustomYieldInstruction Work()
		{
			return null;
		}

		// Token: 0x0601CC11 RID: 117777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC11")]
		[Address(RVA = "0x162B740", Offset = "0x162A340", VA = "0x18162B740")]
		private static void _WriteIl2cppConfigs()
		{
		}

		// Token: 0x0601CC12 RID: 117778 RVA: 0x000A9698 File Offset: 0x000A7898
		[Token(Token = "0x601CC12")]
		[Address(RVA = "0x162B680", Offset = "0x162A280", VA = "0x18162B680")]
		private static bool _IsLowMemoryDevice()
		{
			return default(bool);
		}

		// Token: 0x0601CC13 RID: 117779 RVA: 0x000A96B0 File Offset: 0x000A78B0
		[Token(Token = "0x601CC13")]
		[Address(RVA = "0x162B6E0", Offset = "0x162A2E0", VA = "0x18162B6E0")]
		private static bool _IsPlatformForMmap()
		{
			return default(bool);
		}

		// Token: 0x0601CC14 RID: 117780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC14")]
		[Address(RVA = "0x162B930", Offset = "0x162A530", VA = "0x18162B930")]
		public HotUpdateWriteConfigNode()
		{
		}

		// Token: 0x04025BC9 RID: 154569
		[Token(Token = "0x4025BC9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04025BCA RID: 154570
		[Token(Token = "0x4025BCA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Work;

		// Token: 0x04025BCB RID: 154571
		[Token(Token = "0x4025BCB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__WriteIl2cppConfigs;

		// Token: 0x04025BCC RID: 154572
		[Token(Token = "0x4025BCC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__IsLowMemoryDevice;

		// Token: 0x04025BCD RID: 154573
		[Token(Token = "0x4025BCD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__IsPlatformForMmap;

		// Token: 0x04025BCE RID: 154574
		[Token(Token = "0x4025BCE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
