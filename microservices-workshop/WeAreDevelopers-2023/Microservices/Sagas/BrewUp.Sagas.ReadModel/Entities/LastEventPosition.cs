﻿namespace BrewUp.Sagas.ReadModel.Entities
{
	public class LastEventPosition : EntityBase
	{
		public long CommitPosition { get; set; }
		public long PreparePosition { get; set; }
	}
}
