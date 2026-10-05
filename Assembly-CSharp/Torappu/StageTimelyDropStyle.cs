using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02001441 RID: 5185
	[Token(Token = "0x2001441")]
	[CreateAssetMenu(menuName = "Torappu/UI/Business/StageTimelyDropStyle")]
	public class StageTimelyDropStyle : ScriptableObject, IHotfixable
	{
		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x060077ED RID: 30701 RVA: 0x00035D18 File Offset: 0x00033F18
		[Token(Token = "0x17000E5C")]
		public Color themeColor
		{
			[Token(Token = "0x60077ED")]
			[Address(RVA = "0x254E090", Offset = "0x254CC90", VA = "0x18254E090")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x060077EE RID: 30702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077EE")]
		[Address(RVA = "0x254E030", Offset = "0x254CC30", VA = "0x18254E030")]
		public StageTimelyDropStyle()
		{
		}

		// Token: 0x0400759E RID: 30110
		[Token(Token = "0x400759E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _themeColor;

		// Token: 0x0400759F RID: 30111
		[Token(Token = "0x400759F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_themeColor;

		// Token: 0x040075A0 RID: 30112
		[Token(Token = "0x40075A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
