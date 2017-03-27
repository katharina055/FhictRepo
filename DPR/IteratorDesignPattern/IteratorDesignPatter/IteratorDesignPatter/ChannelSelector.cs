﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatter
{
    class ChannelSelector : IChannelIterator
    {
        TunedChannel aggregate = null;
        int currentId = 0;

        public ChannelSelector(TunedChannel aggregate)
        {
            this.aggregate = aggregate;
        }

        public string Next
        {
            get
            {
                currentId += 1;
                if (currentId<aggregate.Count)
                {
                    return aggregate[currentId];
                }
                else
                {
                    currentId = 0;
                    return aggregate[currentId];
                }
            }
        }

        public string Previous
        {
            get
            {
                try
                {
                    currentId -= 1;
                    return aggregate[currentId];
                }
                catch (Exception)
                {
                    currentId = aggregate.Count-1;
                    return aggregate[currentId];
                }
                
            }
        }
    }
}
