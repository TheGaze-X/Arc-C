using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Torappu.UI
{
	// Token: 0x02003AA3 RID: 15011
	[Token(Token = "0x2003AA3")]
	public class CustomPageActivityStateEntryComp : MonoBehaviour
	{
		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x06017B7C RID: 97148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170038E8")]
		private State parentState
		{
			[Token(Token = "0x6017B7C")]
			[Address(RVA = "0xFE63A0", Offset = "0xFE4FA0", VA = "0x180FE63A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x06017B7D RID: 97149 RVA: 0x00097CB0 File Offset: 0x00095EB0
		[Token(Token = "0x170038E9")]
		public CustomPageActivityStateEntryComp.EntryCompStatus curStatus
		{
			[Token(Token = "0x6017B7D")]
			[Address(RVA = "0xFE6390", Offset = "0xFE4F90", VA = "0x180FE6390")]
			get
			{
				return CustomPageActivityStateEntryComp.EntryCompStatus.Idle;
			}
		}

		// Token: 0x06017B7E RID: 97150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B7E")]
		[Address(RVA = "0xFE5DC0", Offset = "0xFE49C0", VA = "0x180FE5DC0")]
		public void OnRender(bool skipAnim)
		{
		}

		// Token: 0x06017B7F RID: 97151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B7F")]
		[Address(RVA = "0xFE62C0", Offset = "0xFE4EC0", VA = "0x180FE62C0")]
		private void _SampleAllAnimClipAtBegin()
		{
		}

		// Token: 0x06017B80 RID: 97152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B80")]
		[Address(RVA = "0xFE60C0", Offset = "0xFE4CC0", VA = "0x180FE60C0")]
		private void _PlayWithAnim(bool isSkip)
		{
		}

		// Token: 0x06017B81 RID: 97153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017B81")]
		[Address(RVA = "0xFE6020", Offset = "0xFE4C20", VA = "0x180FE6020")]
		private IEnumerator _PlayTargetAnim(bool isSkip, CustomPageActivityStateEntryComp.EntryAnim anim)
		{
			return null;
		}

		// Token: 0x06017B82 RID: 97154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B82")]
		[Address(RVA = "0xFE5F70", Offset = "0xFE4B70", VA = "0x180FE5F70")]
		private void _CheckAllFinish()
		{
		}

		// Token: 0x06017B83 RID: 97155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B83")]
		[Address(RVA = "0xFE5F60", Offset = "0xFE4B60", VA = "0x180FE5F60")]
		private void _DescreasePlayingCount()
		{
		}

		// Token: 0x06017B84 RID: 97156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B84")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CustomPageActivityStateEntryComp()
		{
		}

		// Token: 0x0401CA02 RID: 117250
		[Token(Token = "0x401CA02")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<CustomPageActivityStateEntryComp.EntryAnim> _animList;

		// Token: 0x0401CA03 RID: 117251
		[Token(Token = "0x401CA03")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<UnityEvent> _onAnimEndList;

		// Token: 0x0401CA04 RID: 117252
		[Token(Token = "0x401CA04")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isAnimPlaying;

		// Token: 0x0401CA05 RID: 117253
		[Token(Token = "0x401CA05")]
		[FieldOffset(Offset = "0x2C")]
		private int m_runningAnimCount;

		// Token: 0x0401CA06 RID: 117254
		[Token(Token = "0x401CA06")]
		[FieldOffset(Offset = "0x30")]
		private State m_parentState;

		// Token: 0x0401CA07 RID: 117255
		[Token(Token = "0x401CA07")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x02003AA4 RID: 15012
		[Token(Token = "0x2003AA4")]
		[Serializable]
		private class EntryAnim
		{
			// Token: 0x06017B86 RID: 97158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017B86")]
			[Address(RVA = "0xFEA040", Offset = "0xFE8C40", VA = "0x180FEA040")]
			public EntryAnim()
			{
			}

			// Token: 0x0401CA08 RID: 117256
			[Token(Token = "0x401CA08")]
			[FieldOffset(Offset = "0x10")]
			public UIAnimationLocation animLocaction;

			// Token: 0x0401CA09 RID: 117257
			[Token(Token = "0x401CA09")]
			[FieldOffset(Offset = "0x20")]
			public CustomPageActivityStateEntryComp.EntryAnim.AnimType animType;

			// Token: 0x0401CA0A RID: 117258
			[Token(Token = "0x401CA0A")]
			[FieldOffset(Offset = "0x24")]
			public bool skipAble;

			// Token: 0x0401CA0B RID: 117259
			[Token(Token = "0x401CA0B")]
			[FieldOffset(Offset = "0x28")]
			public Ease ease;

			// Token: 0x0401CA0C RID: 117260
			[Token(Token = "0x401CA0C")]
			[FieldOffset(Offset = "0x2C")]
			public float delayDurationSec;

			// Token: 0x0401CA0D RID: 117261
			[Token(Token = "0x401CA0D")]
			[FieldOffset(Offset = "0x30")]
			public bool enableEvents;

			// Token: 0x02003AA5 RID: 15013
			[Token(Token = "0x2003AA5")]
			[Serializable]
			public enum AnimType
			{
				// Token: 0x0401CA0F RID: 117263
				[Token(Token = "0x401CA0F")]
				LOOP,
				// Token: 0x0401CA10 RID: 117264
				[Token(Token = "0x401CA10")]
				ENTRY
			}
		}

		// Token: 0x02003AA6 RID: 15014
		[Token(Token = "0x2003AA6")]
		public enum EntryCompStatus
		{
			// Token: 0x0401CA12 RID: 117266
			[Token(Token = "0x401CA12")]
			Idle,
			// Token: 0x0401CA13 RID: 117267
			[Token(Token = "0x401CA13")]
			PlayingAvg,
			// Token: 0x0401CA14 RID: 117268
			[Token(Token = "0x401CA14")]
			PlayingTutorial,
			// Token: 0x0401CA15 RID: 117269
			[Token(Token = "0x401CA15")]
			PlayingAnim
		}
	}
}
