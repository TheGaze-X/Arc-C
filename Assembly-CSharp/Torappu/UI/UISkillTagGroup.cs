using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003761 RID: 14177
	[Token(Token = "0x2003761")]
	public class UISkillTagGroup : MonoBehaviour
	{
		// Token: 0x06016824 RID: 92196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016824")]
		[Address(RVA = "0xF025F0", Offset = "0xF011F0", VA = "0x180F025F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06016825 RID: 92197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016825")]
		[Address(RVA = "0xF02110", Offset = "0xF00D10", VA = "0x180F02110")]
		public void Render(List<SkillTagViewModel> tags)
		{
		}

		// Token: 0x06016826 RID: 92198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016826")]
		[Address(RVA = "0xF02A80", Offset = "0xF01680", VA = "0x180F02A80")]
		private void _RespawnTagViews()
		{
		}

		// Token: 0x06016827 RID: 92199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016827")]
		[Address(RVA = "0xF02780", Offset = "0xF01380", VA = "0x180F02780")]
		private UISkillTagView _LoadTag(SkillTagType type, int index)
		{
			return null;
		}

		// Token: 0x06016828 RID: 92200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016828")]
		[Address(RVA = "0xF02540", Offset = "0xF01140", VA = "0x180F02540")]
		private void _HideIdleViews()
		{
		}

		// Token: 0x06016829 RID: 92201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016829")]
		[Address(RVA = "0xF02500", Offset = "0xF01100", VA = "0x180F02500")]
		private static void _AdjustSiblingIndex(Transform transform, int index)
		{
		}

		// Token: 0x0601682A RID: 92202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601682A")]
		[Address(RVA = "0xF02B10", Offset = "0xF01710", VA = "0x180F02B10")]
		public UISkillTagGroup()
		{
		}

		// Token: 0x0401B1ED RID: 111085
		[Token(Token = "0x401B1ED")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject[] _tagPrefabs;

		// Token: 0x0401B1EE RID: 111086
		[Token(Token = "0x401B1EE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _tagContainer;

		// Token: 0x0401B1EF RID: 111087
		[Token(Token = "0x401B1EF")]
		[FieldOffset(Offset = "0x28")]
		private List<SkillTagViewModel> m_tagCache;

		// Token: 0x0401B1F0 RID: 111088
		[Token(Token = "0x401B1F0")]
		[FieldOffset(Offset = "0x30")]
		private List<UISkillTagGroup.ViewHolder> m_spareTagViewPool;

		// Token: 0x0401B1F1 RID: 111089
		[Token(Token = "0x401B1F1")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x02003762 RID: 14178
		[Token(Token = "0x2003762")]
		private class ViewHolder
		{
			// Token: 0x0601682B RID: 92203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601682B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x0401B1F2 RID: 111090
			[Token(Token = "0x401B1F2")]
			[FieldOffset(Offset = "0x10")]
			public SkillTagType type;

			// Token: 0x0401B1F3 RID: 111091
			[Token(Token = "0x401B1F3")]
			[FieldOffset(Offset = "0x14")]
			public bool isIdle;

			// Token: 0x0401B1F4 RID: 111092
			[Token(Token = "0x401B1F4")]
			[FieldOffset(Offset = "0x18")]
			public UISkillTagView view;
		}
	}
}
