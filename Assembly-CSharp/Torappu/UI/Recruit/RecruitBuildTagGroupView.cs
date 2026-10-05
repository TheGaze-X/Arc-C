using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004727 RID: 18215
	[Token(Token = "0x2004727")]
	public class RecruitBuildTagGroupView : MonoBehaviour
	{
		// Token: 0x0601B9B8 RID: 113080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9B8")]
		[Address(RVA = "0x14F9030", Offset = "0x14F7C30", VA = "0x1814F9030")]
		public void Render(BuildTagModel[] tags)
		{
		}

		// Token: 0x0601B9B9 RID: 113081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B9B9")]
		[Address(RVA = "0x14F9440", Offset = "0x14F8040", VA = "0x1814F9440")]
		private Queue<RecruitBuildTagView> _BuildPool(List<RecruitBuildTagView> list)
		{
			return null;
		}

		// Token: 0x0601B9BA RID: 113082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B9BA")]
		[Address(RVA = "0x14F92E0", Offset = "0x14F7EE0", VA = "0x1814F92E0")]
		private RecruitBuildTagView _AllocNormalTag()
		{
			return null;
		}

		// Token: 0x0601B9BB RID: 113083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B9BB")]
		[Address(RVA = "0x14F9390", Offset = "0x14F7F90", VA = "0x1814F9390")]
		private RecruitBuildTagView _AllocSpecialTag()
		{
			return null;
		}

		// Token: 0x0601B9BC RID: 113084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9BC")]
		[Address(RVA = "0x14F9520", Offset = "0x14F8120", VA = "0x1814F9520")]
		private void _RemoveNormalTag(RecruitBuildTagView inst)
		{
		}

		// Token: 0x0601B9BD RID: 113085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9BD")]
		[Address(RVA = "0x14F9590", Offset = "0x14F8190", VA = "0x1814F9590")]
		private void _RemoveSpecialTag(RecruitBuildTagView inst)
		{
		}

		// Token: 0x0601B9BE RID: 113086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B9BE")]
		[Address(RVA = "0x14F9600", Offset = "0x14F8200", VA = "0x1814F9600")]
		public RecruitBuildTagGroupView()
		{
		}

		// Token: 0x04023C89 RID: 146569
		[Token(Token = "0x4023C89")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RecruitBuildTagView _normalTagPrefab;

		// Token: 0x04023C8A RID: 146570
		[Token(Token = "0x4023C8A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RecruitBuildTagView _specialTagPrefab;

		// Token: 0x04023C8B RID: 146571
		[Token(Token = "0x4023C8B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04023C8C RID: 146572
		[Token(Token = "0x4023C8C")]
		[FieldOffset(Offset = "0x30")]
		private List<RecruitBuildTagView> m_normalTagInsts;

		// Token: 0x04023C8D RID: 146573
		[Token(Token = "0x4023C8D")]
		[FieldOffset(Offset = "0x38")]
		private List<RecruitBuildTagView> m_specialTagInsts;
	}
}
