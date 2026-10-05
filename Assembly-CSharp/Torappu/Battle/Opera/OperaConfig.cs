using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.Opera
{
	// Token: 0x0200269E RID: 9886
	[Token(Token = "0x200269E")]
	[CreateAssetMenu(menuName = "Torappu/Level/OperaConfig")]
	public class OperaConfig : ScriptableObject
	{
		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x06010266 RID: 66150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002329")]
		public List<OperaCommand> commands
		{
			[Token(Token = "0x6010266")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06010267 RID: 66151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010267")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public OperaConfig()
		{
		}

		// Token: 0x04011FE5 RID: 73701
		[Token(Token = "0x4011FE5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<OperaCommand> _commands;
	}
}
